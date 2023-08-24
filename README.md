# .NET PriorityQueue for Unity

This repository provides the [`PriorityQueue`][msdn_priority_queue] from .NET 6 and up
as a UPM package.

[msdn_priority_queue]: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.priorityqueue-2?view=net-7.0

## Changes compared to the `PriorityQueue` in .NET 6 and up

The `PriorityQueue` provided by this package is a faithful copy of the `PriorityQueue`
provided in .NET 6 and up with the following changes:

* The `PriorityQueue` has been placed in the `BeardedPlatypus.Collections.Generic` to
  ensure it does not clash in the future if the `PriorityQueue` is added to Unity.
* `Array.MaxSize` has been replaced by `int.MaxValue`.
* Exception messages have been moved to a separate class.
* Exception methods have been moved to `ExceptionExtensions`.

## Installing this package into your Unity project

The package can be installed through the "package manager". Click on the "Add package
from GIT url..." and add the following url:

```
https://github.com/BeardedPlatypus/unity-net-priority-queue.git
```
## Attribution

The source files are copied from [the `PriorityQueue.cs`][priorityqueue.cs] and 
related files in [the dotnet runtime repository][dotnet_runtime].

[priorityqueue.cs]: https://github.com/dotnet/runtime/blob/main/src/libraries/System.Collections/src/System/Collections/Generic/PriorityQueue.cs
[dotnet_runtime]: https://github.com/dotnet/runtime/tree/main
