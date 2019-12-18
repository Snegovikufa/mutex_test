#!/bin/bash
echo "<>!!!<>"
dotnet MutexTest.dll &
echo "Running second app"
dotnet MutexTest.dll
