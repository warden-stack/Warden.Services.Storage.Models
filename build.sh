#!/bin/bash
dotnet restore "https://api.nuget.org/v3/index.json" --no-cache
dotnet pack  -o .
