using UnityEngine;
using Unity.MLAgents;

namespace Unity.MLAgentsExamples
{
    [DisallowMultipleComponent]
    public class AgentContact : MonoBehaviour
    {
        [HideInInspector] public Agent agent;

        [Header("Agent Check")] public bool agentDoneOnAgentContact; // Whether to reset agent on agent contact.
        public bool rewardAgentContact; // Whether to reward on agent contact.
        public float agentContactReward; // reward amount.
        public bool touchingAgent;
        const string k_Agent = "agent"; // Tag of agent object.

        /// <summary>
        /// Check for collision with agent, and optionally reward agent.
        /// </summary>
        void OnCollisionEnter(Collision col)
        {
            if (col.transform.CompareTag(k_Agent))
            {
                touchingAgent = true;
                if (rewardAgentContact)
                {
                    agent.SetReward(agentContactReward);
                }

                if (agentDoneOnAgentContact)
                {
                    agent.EndEpisode();
                }
            }
        }

        /// <summary>
        /// Check for end of agent collision and reset flag appropriately.
        /// </summary>
        void OnCollisionExit(Collision other)
        {
            if (other.transform.CompareTag(k_Agent))
            {
                touchingAgent = false;
            }
        }
    }
}


