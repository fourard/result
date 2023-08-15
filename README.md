# Fourard.Result

[![](https://img.shields.io/nuget/vpre/Fourard.Result)](https://www.nuget.org/packages/Fourard.Result)
[![](https://img.shields.io/nuget/dt/Fourard.Result)](https://www.nuget.org/packages/Fourard.Result)
[![](https://img.shields.io/github/license/fourard/result.svg)](https://raw.githubusercontent.com/fourard/result/main/LICENSE)
[![](https://img.shields.io/github/issues/fourard/result.svg)](https://github.com/fourard/result/issues)
[![](https://img.shields.io/github/contributors/fourard/result.svg)](https://github.com/fourard/result/graphs/contributors)

A modern implementation of the operation result pattern for C#

## Table of contents

- [Setup](#setup)
- [Implementation](#implementation)
- [Handling results](#handling-results)
- [Handling failures and exceptions](#handling-failures-and-exceptions)
- [Stacking operations](#stacking-operations)
- [Auto Deconstruction](#auto-deconstruction)
- [Mapping](#mapping)

## Setup

Define a type for your expected successful result

```csharp
public class Person
{
    public string Name { get; set; }
}
```

Define a type for your expected failure result (Optional)

```csharp
public class Error
{
    public string Code { get; set; }
    public string Message { get; set; }
}
```

Use it as the return type for your methods

```csharp
using Fourard.Result;

public interface IPersonService
{
    Result<Person> GetPerson();
    Result<Person, Error> GetPersonOrError();
}
```

## Implementation

Explicitly return a result option

```csharp
using Fourard.Result;

public class PersonService : IPersonService
{
    public Result<Person, Error> GetPerson()
    {
        var person = new Person() { Name = "Alice" };
        return new Success<Person, Error>(person);
    }
}
```

Using implicit conversions

```csharp
using Fourard.Result;

public class PersonService : IPersonService
{
    public Result<Person, Error> GetPerson()
    {
        return new Person() { Name = "Alice" };
    }
}
```

Handling successes, failures and exceptions

```csharp
public class PersonService : IPersonService
{
    public Result<Person, Error> GetPerson()
    {
        try
        {
            // execute some validation
            var valid = true;

            if (!valid)
            {
                var error = new Error() { Code = "ERROR_CODE", Message = "ERROR_MESSAGE" };
                return new Failure<Person, Error>(error);
            }

            var person = new Person() { Name = "Alice" };
            return new Success<Person, Error>(person);
        }
        catch (Exception exception)
        {
            return new Unhandled<Person, Error>(exception);
        }
    }
}
```

Again, the implicit version

```csharp
public class PersonService : IPersonService
{
    public Result<Person, Error> GetPerson()
    {
        try
        {
            // execute some validation
            var valid = true;

            if (!valid)
            {
                return new Error() { Code = "ERROR_CODE", Message = "ERROR_MESSAGE" };
            }

            return new Person() { Name = "Alice" };
        }
        catch (Exception exception)
        {
            return exception;
        }
    }
}
```

## Handling results

Using the **is** operator

```csharp
public Person? GetPersonOrDefault()
{
    var service = new PersonService();

    var result = service.GetPerson();

    if (result is Success<Person, Error> success)
    {
        return success.Value;
    }

    return default;
}
```

Using a **switch expression**

```csharp
public Person? GetPersonOrDefault()
{
    var service = new PersonService();

    var result = service.GetPerson();

    return result switch
    {
        Success<Person, Error> success => success.Value,
        Failure<Person, Error> failure => default,
        Unhandled<Person, Error> unhandled => default,
    };
}
```

Using the **GetValueOrDefault** extension method that pretty much does the same thing

```csharp
public Person? GetPersonOrDefault()
{
    var service = new PersonService();

    var result = service.GetPerson();

    return result.GetValueOrDefault();
}
```

## Handling failures and exceptions

Using a **switch** statement

```csharp
public void GetPersonAndDoSomething()
{
    var service = new PersonService();

    var result = service.GetPerson();

    switch (result)
    {
        case Success<Person, Error> success: DoSomethingWithPerson(success.Value); break;
        case Failure<Person, Error> failure: LogError(failure.Error); break;
        case Unhandled<Person, Error> unhandled: LogException(unhandled.Exception); break;
    }
}
```

Using the friendly **Handle** extension method

```csharp
public void GetPersonAndDoSomething()
{
    var service = new PersonService();

    var result = service.GetPerson();

    result.Handle(
        person => DoSomethingWithPerson(person),
        error => LogError(error),
        exception => LogException(exception)
    );

    // Or even
    result.Handle(DoSomethingWithPerson, LogError, LogException);
}
```

Also works on async scenarios

```csharp
public async Task GetPersonAndDoSomething()
{
    var service = new PersonService();

    var result = service.GetPerson();

    await result.Handle(
        async person => await DoSomethingWithPerson(person),
        async error => await LogError(error),
        async exception => await LogException(exception)
    );

    // Or just
    await result.Handle(DoSomethingWithPerson, LogError, LogException);
}
```

## Stacking operations

It's very common having a multi-step process, so the **Handle** extension method can be stacked

```csharp
public class PersonService
{
    public Result<Person, Error> GetPerson(); // implementation omitted
}

public class EmployeeService
{
    public Result<Employee, Error> RegisterNewEmployee(Person person); // implementation omitted
}

public class ScheduleService
{
    public Result<Schedule, Error> RegisterNewEmployeeSchedule(Employee employee); // implementation omitted
    public void SendScheduleToHumanResources(Schedule schedule); // implementation omitted
}

public class EmployeeFactory
{
    public void CreateEmployee()
    {
        var personService = new PersonService();
        var employeeService = new EmployeeService();
        var scheduleService = new ScheduleService();

        // Could be easier than this?
        personService.GetPerson()
            .Handle(employeeService.RegisterNewEmployee, LogError, LogException)
            .Handle(scheduleService.RegisterNewEmployeeSchedule, LogError, LogException)
            .Handle(scheduleService.SendScheduleToHumanResources, LogError, LogException);
    }

    private void LogError(Error error); // implementation omitted
    private void LogException(Exception exception); // implementation omitted
}
```

In the above example, the next routine is only executed if the previous was successful, so your flow will work as expected.

You can even return the last **Handle** result and handle it in another place

```csharp
public Result<Schedule, Error>? CreateEmployeeAndGetSchedule()
{
    // Returning the result of RegisterNewEmployeeSchedule to handle in another method
    return personService.GetPerson()
        .Handle(employeeService.RegisterNewEmployee, LogError, LogException)
        .Handle(scheduleService.RegisterNewEmployeeSchedule, LogError, LogException);
}

public void CreateEmployee()
{
    var result = CreateEmployeeAndGetSchedule();
    result.Handle(DoSomethingWithSchedule, LogError, LogException);
}
```

## Auto Deconstruction

**Handle** has a special behavior when the returning type of a result is a tuple.

```csharp
public Result<(Person, Schedule), Error>? GetPersonAndSchedule()
{
    // ...
}

public Result<Configuration, Error>? DoSomeConfigurationToPersonSchedule(Person person, Schedule schedule)
{
    // ...
}

public void ConfigurePerson()
{
    var result = GetPersonAndSchedule().Handle(DoSomeConfigurationToPersonSchedule);
}
```

Notice that, the **DoSomeConfigurationToPersonSchedule** method doesn't receive a tuple, but individual parameters.
You can return up to 8 items in a tuple and get the same behavior.

```csharp
public Result<(int, int, int, int, int, int, int, int), Error>? GetNumbers()
{
    return (1, 2, 3, 4, 5, 6, 7, 8);
}

public void RunNumbersOperation()
{
    var result = GetNumbers().Handle((a, b, c, d, e, f, g, h) => a + b + c + d + e + f + g + h);
}
```

## Mapping

You can also map the content of a result to another type.

```csharp
public Result<int, string> GetInteger()
{
}

public void MapIntegerResult()
{
    Result<string, string> result = GetInteger().Map(integer => integer.ToString());
}
```

The error can be mapped too!

```csharp
public void MapIntegerResultAndStringError()
{
    Result<string, int> result = GetInteger().Map(integer => integer.ToString(), error => int.Parse(error));
}
```
