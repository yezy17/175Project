# 175Project
A Rubber and Guard project based on [ML-Agents toolkits](https://github.com/Unity-Technologies/ml-agents).

### How to Run:

The environment installation guide is [here](https://github.com/Unity-Technologies/ml-agents/blob/release_20_docs/docs/Installation.md).

use the command line:

- Train Walker:

  ```
  mlagents-learn config/Walker.yaml --run-id=Walker_1 --torch-device="cuda" --force
  ```

- Train Rubber and Guard with PPO:

  ```
  mlagents-learn config/twoWalker.yaml --run-id=twoWalker_1 --torch-device="cuda" --force
  ```

- Train Rubber and Guard with PPO and Self-Play:

  ```
  mlagents-learn config/twoWalkerSelfPlay.yaml --run-id=twoWalkerSP_1 --torch-device="cuda" --force
  ```

### One-line description for each file:

![](.\graph\one-line.png)



