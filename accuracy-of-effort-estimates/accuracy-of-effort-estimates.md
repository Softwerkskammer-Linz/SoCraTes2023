# Improving the accuracy of effort estimates

By Thomas Aglassinger, software developer ([Web](https://roskakori.at/) | [LinkedIn](https://www.linkedin.com/in/thomas-aglassinger))

## Introduction

When working on projects, software developers (and people from other sectors) are often asked to estimate the required effort of certain tasks or entire projects. This poses several challenges. Large differences between estimated and actual effort can cause conflicts inside the team or with the customer, lose a call for bids, or have unexpected low profit or high need for resources.

In this open discussion I share challenges I faced and provide suggestion on how to deal with them. Additionally, we collect additional ideas and situation from the audience. 

This resulting document is intended to provide inspiration for you and your team on how to estimate, track and compare effort, and consequently identify the pain points where to focus on improving your estimation accuracy. This should increase trust and consequently reduce the need for estimations.

## Out of scope

Before we dive into the subject, here are some topics we are not going to discuss in depth because they would diverge too much from the core topic. Some are even more difficult to discuss in depth.  

- #NoEstimate: Estimation is wasteful and does not change the actual effort. Therefore, it should not be part of the process at all. However, with a very limited budget that has to be spent carefully or a customer asking for an estimate during a call for bids, it might be needed.
- Low effort estimation: Perform a very rough estimate (10/100/1000) based on past experience and use it for go/no-go decision. Then charge costs based on the actual effort. However, this might not fit the needs of the customer, especially without having collaborated in prior projects.
- Value based estimation: Don't use economic viability as the main driver but include perspectives like customer satisfaction, fun factor ecologically beneficial, employee satisfaction, etc. This approach is very different and might require major changes in organization and culture before it can be pursued. It can somewhat be combined with story points. However, it is often vague when it comes down to actually implementing it. Finding tools and people sharing their experience with it can be hard.
- Complexity vs effort: It is hard to define complexity in a way everyone can agree on (not only developers) and then actually use it in a meaningful way for estimation.

## Where to get the actual effort?

Challenge: In order to talk about the accuracy of your estimates, you need to actually know it. While it is fairly simple to store the estimates in a spreadsheet or with the issue tracker, knowing the actual effort is more difficult.

Suggested sources of actual effort:

- Time tracking: Collects the time a person has been working on a project or task.
- Cost accounting (German: "Kostenrechnung")
  - cost of labor is major driver in software development
  - other sectors might also have large material cost

For comparison, try to automate within reason concerning resources used:
- Write a few macros or API scripts (but: bad usability, break easily)
- Implement a company-wide application (but: expensive)
- Try to use only tools that provide this information out of the box (but: few available, vendor lock-in, limited scope, possibly expensive).

If automation is not feasible, periodically copy values  into a spreadsheet. However, this is cumbersome and error-prone.

## Information is available but developers have no access to it

Challenge: The information of estimated and actual effort is only available to a few selected people, for example the project manager.

Suggestion: Establish means that people can access information about the estimated and actual effort for tasks they contributed to. Everyone should also know what their own "correction factor" is concerning estimation. For example: 30% means that after estimating a task, you need to add another 30% to the probable actual effort. 

This factor tends to shrink with increasing experience in a sector and familiarity with the subject of the project. Still, expected blunders to be happening occasionally.

## Privacy

Challenges:

- Laws or the worker's council might limit the level of detail you are allowed in tracking the actual effort spent.
- If multiple people work on a task, they might contribute to possible mis-estimation on a different scale. This information could be abused for finger pointing and other undesirable activities.

Suggestions:

- Be aware of laws that apply in the context of collecting data about actual effort.
- Integrate worker and a possible worker's council in your considerations early on and make the purpose and advantages transparent to them.
- Be mindful about who can see whose data on what level of detail.
- Establish a positive error culture and nurture the general maturity of everyone involved. 

## Different units for estimated effort

Challenge: Estimated and actual effort might use different units. Common units are:

- time
  - average cost vs. cost depending on role (developer, tester, architect, ...) or experience (junior, senior, ...)
- Story points
- Euro (or other monetary currency)
- Running costs for a team per sprint -> Project costs = number of sprints needed

Suggestion: For comparison between estimated and actual effort, convert everything to Euro. This is what the customer pays in and what employees get paid in.

## Granularity

Challenge: Effort can be estimated and tracked on different granularity. For example:  

- Project: Many projects seem to be able to have a rough sum total estimation in the beginning to make the go/no-go decision, and are aware of the total cost in the end. Though there are cases where even this information is unavailable.
- Milestone: Neither in my experience not the audience's have milestone been used as main granularity for estimation.
- Task: Some projects are able to use this, and it has been shown to be valuable. However effort is need to provide processed and tooling for that.
- Activity (design, implementation, review, testing, ...): 

Suggestions: 

Try to at least have an estimation of the entire project, and know the total actual effort or cost needed to implement it. Otherwise, it is difficult to know even basic economic KPI like the profit margin, that would be needed to make strategic decision affecting the entire project, team or even company. 

Aim at task based estimations. Tasks provide a limited scope, so if things go wrong, also the scope of ideas to fix and improve this has a limited scope. This allows to be more focussed and directed when looking for ways to improve.

In case all tasks are estimated, the sum total also provides an estimate for the entire project. If only some tasks are estimated (e.g. the ones with the highest risks), try to have an additional total project estimate (see above for the reasoning).

Activity based estimation takes even more effort than task based and might not be feasible. If you have activity based time tracking, the total amount (independent of any project) can already be used without estimate to identify general organizational shortcomings (e.g. little time is spent on development and a lot on testing -> Incomplete or confusing requirements? Low quality of initial implementation? ...?).

## Sales estimations

Challenge: Sales and developer estimation might differ, which might cause frustration and concern with different parties.

Example:

1. initial sales estimate: €100K
2. developer estimate: €300K 
3. final consensus estimate passed to the customer as actual price: €150K
4. final actual cost: €250

Result:

- Sales: "Yeah, we rock, because the customer took the contract and the company made €150K of revenue!" 🎉
- Developers: "Yeah, we rock, we needed €50K less than estimated!" 🎉
- CEO: "You all suck because the company just lost €100K!" 😡

Suggestions:

Be internally transparent about the different estimates communicated to different parties. If the product is sold below the costs estimated by the developers, make it clear that this is a strategic decision where a low or negative margin is accepted to underbid competitors and recover profits later.

Some possibilities to recover profits later are:

- Pass on running costs to the customer with a better margin. For example: Maintenance, support.
- Cross-selling: Sell other services or products to the same customer that provide value to them. For example, technical infrastructure and operations of the software you developed for them.
- Up-selling: Have future projects with the same customer. Sell standard addons that are already available and provide value to the customer. 
- Resell the project result to another customer.

## Uncertainty

Challenge: For a task with many unknowns, it is hard to provide a serious estimate.

Suggestion: 

For such tasks, do not use a single value as estimate (e.g. 150h) rather than a from/to range (e.g. 100-200h).

If there are multiple such tasks in the project, sum up the minimum and maximum to have a general feel for the risk on the total budget.

If the risk is too high, implement prototypes or [spikes](https://en.wikipedia.org/wiki/Spike_(software_development)) with a limited budget and use the findings to perform a re-estimation based on better understanding.

## Common understanding of what is needed

Challenge: While customer, project managers, developers and other roles intend to work towards the same goal, they don't always have the same understanding what this goal actually is.

For example, customers talk about what they want, requirements engineers try to find out what they actually need, developers have their own perspective what can be done with reasonable effort, project managers need to have enough understanding of everything to haggle with the customer about the cost and priorities.

Suggestion: Communication, among other things:

- When discussing major topics with the customer, consider taking both project manager and developer to them.
- Have a [ubiquitous language](https://www.agilitest.com/cards/ubiquitous-language) that is used throughout the project in every document (including source code) and conversation.
- Solid requirements engineering (see literature about the topic). Write them down and have everyone involved have access to the same documents / issue tracker.
- Assuming the basic requirements are clear, validate that everyone understands them in the same way. Especially at an early level of the project and way before any refinements.

## Trust

Given enough trust between customer and the various roles in the development team, experience suggests that project team can move away from vigorously estimated projects to #NoEstimates or low effort estimation and focus resources on implementation.

Knowing and constantly improving the accuracy of your estimates in the early phase of a customer relationship can act as important building block towards trust.

It might still be required to identify and estimate tasks with many unknowns and evaluate the risks involved. In turn, this help preserving existing trust.

With enough trust, it becomes easier to agree on switching to an effort based cost model. 

