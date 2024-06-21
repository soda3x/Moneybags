# Style guide for Moneybags

This style guide is for Java programming for the Moneybags project.

This style is primarily based on [Google's Java Styleguide](https://google.github.io/styleguide/javaguide.html).

## Indenting

Text is indented with 2 spaces

## if-else blocks

```java
if (something) {
    // logic here
} else if (somethingElse) {
    // different logic here
} else {
    // even more different
}
```

## Variables

### Member variables

Private member variables are prefixed with `m_`

```java
private int m_age = 30;
```

Member variables use camelCase:

```java
public String firstName = "Brad";
```

### Constants

Constants are in ALL_CAPS with underscores to separate words:

```java
private static final APP_VERSION = "1.0.0";
```

## Methods

Methods names use camelCase:

```java
private void doSomething() {}
```

Brackets are as such:

Do:

```java
private void doSomething() {
    // happy days
}
```

Don't:

```java
private void doSomething()
{
    // this is not right
}
```

## Case statements and fall-through behaviour

Fall through is fine as long as there is a comment to inform that it is intentional:

```java
switch (dayOfWeek) {
    case "Saturday":
        // Intentional fall-through
    case "Sunday":
        return "good";
    default:
        return "not good";
}
```

## Interfaces

Interfaces are prefixed with `I`:

```java
public interface IMyInterface
```