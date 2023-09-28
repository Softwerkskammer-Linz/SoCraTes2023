# pre-commit

By Thomas Aglassinger, software developer ([Web](https://roskakori.at/) | [LinkedIn](https://www.linkedin.com/in/thomas-aglassinger))

## Introduction

Ensuring a consistently high quality for source code is a challenge every software development team has to face one way or another. Human code reviews are one tool that can help with that. However, there always is a danger of them being bogged down by trivial issues like formatting mistakes. This wastes time for that human reviewer that would prefer to focus on real issues like hard to understand design decisions, questionable scalability or lack of robustness. 

The source control system [git](https://git-scm.com/) supports so-called "hooks" that can act on certain git events. One of them are pre-commit hooks, which can run little scripts or programs before changes are committed. These particular hooks are useful to perform small checks and clean up the source code to be committed. The intention is to find and fix minor issues in the code before they pop up in a human code review. Consequently, they save time for human reviewers.

For example, pre-commit hocks can remove trailing white space or ensure that your code starts with a license comment.

The command line tool and framework [pre-commit](https://pre-commit.com/) allows to manage and implement pre-commit hooks using a configuration file. Many standard hooks for multiple programming languages already exist that can be added to your project by adding a few lines to your `.pre-commit-config.yaml`.

In this open discussion I share hooks that I found helpful to improve the code quality of my projects. Additionally, we collect hooks that people from the audience found useful.

If you are looking for more hooks, a good starting point is the [collection of popular hooks](https://pre-commit.com/hooks.html) by the pre-commit project.

## Basic pre-commit usage

The pre-commit tool can be downloaded and installed as described on its [website](https://pre-commit.com/).

Next, add a file `.pre-commit-config.yaml` to your project. A very simple one could look like this:

```yaml
repos:
-   repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v2.3.0
    hooks:
    -   id: check-yaml
    -   id: trailing-whitespace
```

This checks if all YAML files in your project are syntactically correct, and removed trailing white space from text files.

To check if the files on your current git change list conform, run:

```bash
pre-commit
```

To check if all files in your repository pass, run:
```
pre-commit --all-files
```

As the authors of pre-commit hooks might update them from time to time, you also want to ensure your project uses the most current version. For that, run:

```bash
pre-commit autoupdate
```

## General

A collection of general hooks that can be helpful for many projects:

```yaml
  - repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v4.4.0
    hooks:
      - id: fix-byte-order-marker
        # Helpful for teams where some members use Windows and Microsoft editors,
        # and others Unix or macOS

      - id: trailing-whitespace
        # Ensure that each line in a text files does not have white space at the end,
        # which would only waste storage.

      - id: end-of-file-fixer
        # Ensure that each text file ends with a new line. Otherwise, some badly
        # coded unix tools might get confused when processing them.

      - id: check-added-large-files
        # Prevents you from accidentally adding large files, for example a ZIP you
        # dropped and extracted in the project folder.

      # Check various file formats for syntactical correctness.
      - id: check-json
      - id: check-toml
      - id: check-xml
      - id: check-yaml

      - id: check-merge-conflict
        # Check that the source code does not contain any markers indicating that a
        # merge conflict has yet to be resolved.

      - id: mixed-line-ending
        # Check that the end of lines in a text file are consistent
        # (Windows uses CR+LF, Unix LF and macOS classic CR).
        #
        # Note that you can also set ".gitattributes" to let git ensure that, see
        # <https://www.git-scm.com/docs/gitattributes>.
```

## General: Tabs

In case you have a policy to only use blanks and avoid tabs:

```yaml
- repo: https://github.com/Lucas-C/pre-commit-hooks
  rev: v1.5.4
  hooks:
    - id: remove-tabs
      args: [--whitespaces-count, '2']  # defaults to: 4
      exclude: Makefile
```

Note that we are excluding `Makefile` because it [demands tabs as part of its syntax](https://beebo.org/haycorn/2015-04-20_tabs-and-makefiles.html). 😑

## General: Symbolic links

If your project uses [symbolic links](https://en.wikipedia.org/wiki/Symbolic_link):

```yaml
  - repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v4.4.0
    hooks:
      - id: destroyed-symlinks
      # Detect symbolic links which are changed to regular files 
      # with a content of a path which that symlink was pointing to. 
```

### General: No commit to branch

To protect e.g. main from direct commits without feature branch.

```yaml
  - repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v4.4.0
    hooks:
      - id: no-commit-to-branch
        args: ["--branch", "main", "--branch", "production"]
```

### General: insert license

```yaml
  - repo: https://github.com/Lucas-C/pre-commit-hooks
    rev: v1.5.4
    hooks:
      - id: insert-license
        files: \.(po|py)$
        args:
          - --license-filepath=LICENSE
          - --comment-style=#
          - --detect-license-in-X-top-lines=2
          - --no-extra-eol
          - --allow-past-years # Using these arguments allows for a date range
          - --use-current-year # (original_date - current_date) to be generated.
```


## Pretty printers

- [Prettier](https://prettier.io/): Pretty prints CSS, HTML, JavaScript, Markdown and more.

```yaml
  - repo: https://github.com/pre-commit/mirrors-prettier
    rev: v3.0.3
    hooks:
      - id: prettier
```


- [black](): Pretty prints Python
```yaml
  - repo: https://github.com/ambv/black
    rev: 23.9.0
    hooks:
      - id: black
```


  - [isort](): Sorts Python `import` consistently
```yaml
  - repo: https://github.com/pre-commit/mirrors-isort
    rev: v5.10.1
    hooks:
      - id: isort
```

## Dotnet

In general [husky.net](https://alirezanet.github.io/Husky.Net/) can help with managing git hooks.

To format code:

```yaml
  - repo: https://github.com/dotnet/format
    rev: ""
    hooks:
      - id: dotnet-format
        args: [--folder, --include]
```

### Programming languages

For many programming languages, additional pre-commit hooks exist. Here are some examples.

### Java

The audience recommendation was to include formatting and linting in the build process. In order to do that, many plugins for [Maven](https://maven.apache.org/) already exist.

### JavaScript etc

You can run [eslint via pre-commit](https://github.com/pre-commit/mirrors-eslint). The actual configuration depends on the plugins your project uses, so refer to the documentation for details.

### Shell scripts

```yaml
  - repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v4.4.0
    hooks:
    - id: check-executables-have-shebangs
      # Check that shell scripts start with something like "#!/bin/sh"

    - id: check-shebang-scripts-are-executable
      # Check that on Unix shell scripts also have the "chmod x" set and
      # can does be run directly without calling "sh" (or something similar).
```

### Python

```yaml
  - repo: https://github.com/pre-commit/pre-commit-hooks
    rev: v4.4.0
    hooks:
      - id: check-ast 
        # Check that Python source code is syntactically correct by
        # parsing its abstract syntax tree (AST).

      - id: debug-statements
        # Check for debug statements that would stop the application when
        # encountered (pdb, ipdb, rdb).

  - repo: https://github.com/asottile/pyupgrade
    rev: v3.10.1
    hooks:
      - id: pyupgrade
        args: ["--py310-plus"]
      # Ensure Python source code effectively uses language features that have been added at some point.
```

For linting there are multiple solutions:

  - [flake8](https://flake8.pycqa.org/en/latest/user/using-hooks.html): Limited and simple
```yaml
  - repo: https://github.com/PyCQA/flake8
    rev: 6.1.0
    hooks:
      - id: flake8
        additional_dependencies: ["pep8-naming==0.13.3"]
```

  - [pylint](https://pylint.pycqa.org/en/latest/user_guide/installation/pre-commit-integration.html): Flexible and complex, requires a lot of configuration 

If you are using the [Django web framework](https://www.djangoproject.com/):

```yaml
  - repo: https://github.com/ecugol/pre-commit-hooks-django
    rev: v0.4.0
    hooks:
      - id: check-untracked-migrations
      - id: check-unapplied-migrations
      - id: check-absent-migrations
      # Various checks to perform on database migrations.

  - repo: https://github.com/rtts/djhtml
    rev: 3.0.6
    hooks:
      - id: djhtml
        # Indent only HTML files in template directories.
        files: .*/templates/.*\.html$
        # Indent HTML files that include Django's macro language,
        # which can not be formatted using Prettier.
```

## Security

[Gitleaks](https://github.com/gitleaks/gitleaks) detects attempts to commit secret keys as part of the source code. 

```yaml
  - repo: https://github.com/gitleaks/gitleaks
    rev: v8.18.0
    hooks:
      - id: gitleaks
```

## Local hooks

In addition to using hooks from git repositories, you can also add your own local hooks. As example consider a hook that prevents you from committing files with the suffix ".rej":

```yaml
- repo: local
  hooks:
  - id: forbidden-files
    name: forbidden files
    entry: found Copier update rejection files; review them and remove them
    language: fail
    files: "\\.rej$"
```

## Testing

For testing, create a script to runs the tests with all options needed to do so. For example, `scripts/run_tests.sh`, in a Python project using poetry for package management and pytest for testing, you could use:

```bash
#!/bin/sh
poetry run pytest
```

Then add a local hook to run this upon commit:

```yaml
- repo: local
  hooks:
  - id: run_tests
    language: script
    name: Run tests
    entry: ./scripts/run_test.sh
```

## Sharing pre-commit-config across projects

For teams with multiple similar projects and can save effort by having a common template for the `.pre-commit-congig.yaml` that is shared across projects.

If you want to do that, take a look at tools like [copier](https://copier.readthedocs.io/en/stable/) or [cookiecutter](https://github.com/cookiecutter/cookiecutter).
