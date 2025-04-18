# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.4.1] - 2024-09-25
### Fixed
- Client.Read byteCount type.

## [2.4.0] - 2024-01-06
### Changed
- Made timeouts client properties.

## [2.3.1] - 2024-01-06
### Fixed
- Setting stream delay after stream change.

## [2.3.0] - 2024-01-05
### Added
- Properties for communication settings.

## [2.2.2] - 2023-09-20
### Fixed
- Missing NetworkStream lock.

## [2.2.1] - 2023-08-01
### Fixed
- IDisposable implementation.

## [2.2.0] - 2022-11-12
### Changed
- .NET 6.0 target to .NET Standard 2.0.

## [2.1.0] - 2022-10-12
### Added
- ConnectTimeout property.

### Changed
- Disabled Nagle's algorithm.

## [2.0.1] - 2022-10-11
### Added
- ExceptionCode enum.
- DelayAfterRead property.

### Changed
- FunctionCode enum naming.
- Timeout property to ReadTimeout property.

### Fixed
- ReadTimeout setting in examples.