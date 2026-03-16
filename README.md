**Why merge was not fast-forward**
The `feature-max` branch was created from `main`, then `main` received a new commit (clarified prompt). 
Because `main` had moved forward since the branch point, Git could not simply advance the `main` pointer to `feature-max`; instead it created an explicit merge commit that records the integration of two divergent histories.
