## 1. When does Git perform a fast-forward and when is a merge commit created?
Git performs fast-forward merge whenthe target branch has not received any new comits since the feature branch was created. in this situation Git simply moves the branch pointer forward to the newest commit.

A merge commit is created when both branches have new commits. Because the histories diverged Git must create a new commit that combines the two histories.

## Example from this repository:  
The `feature-max" branch was created from `main`, but before merging it, an additional commit was added directly to `main`. Because `main` moved forward, Git created a merge commitinstead of performing a fast-forward.
--
## 2. What is the practical difference between merge and rebase?
Merge combines the histories of two branchesby creating a merge commit that has two parent commits. it preserves the full branching structure and shows when branches were integrated.

Rebase moves the commits from onebranch and reapplies them on top of another branch. this rewrites the commit history and produces a linear sequence of commits without merge nodes.
In practice:
- merge preserves the original branching structure
- rebase creates a cleaner, linear history
---
## 3. How was the conflict resolved in your repository?

Conflict occurredwhen both `main" and "feature-conflict` modified the same line in `Program.cs`. Git marked conflicting sections with conflict symbols like `<<<<<<<`, `=======`, `>>>>>>>`

Then I resolved conflict manually by editing the file, choosing a final version of the output message, and removing the conflict markers. After verifying that the program still compiled correctly, the resolved file was staged and committed to complete the merge.
