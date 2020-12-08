# Project Resume

The goal of the project is to create a simple webapplication that features a Vue
frontend and a .NET 3.1 API.

**Important:** This is a practice project to learn .NET Core and as a demo 
project for future contracts. Suggestions on how to improve are extremely 
appriciated.

Feature roadmap:

- [ ] List of projects (title, thumbnail, short description, used technologies)
- [ ] Tag system (one tag per technology) to be assigned to projects
- [ ] Filtering based on tags
- [ ] Custom markdown parsing to generate summarized list of functionalities per
  technology
	```markdown
	This project consists of a <highlight tag="nodejs" short="Node.js API using 
	Express">Node.js RESTful API using the Express web framework</highlight>
	```


-------------------

## Custom tag parsing

Custom tag parsing should be used to highlight certain technologies in the 
description of a project. Imagine the following markdown content:

```markdown
This project uses <highlight tag="redis" short="Storing worker jobs">Redis to 
store jobs to be processed by worker-threads that can be scaled 
accordingly</highlight>.

... (more text)

To speed up API responses and prevent expensive queries to run every request, 
<highlight tag="redis" short="Caching database results">Redis is used to cache 
database's data</highlight> and cache is invalidated whenever the data is 
changed by an administrator.
```

These `<highlight>` tags will be parsed on saving the project's description. 
When loading a list of all projects that have the tag `Redis`, a summary is
shown as following:

> **Project name**
>
> Short description about project
>
> `Redis` is used for:
> - Storing worker jobs
> - Caching database results

When viewing the detail page of a project, the `<highlight>` tag is replaced by
a regular HTML `<mark>` that is styled to underline the given text with a
color that matches the tag's given color

-------------------