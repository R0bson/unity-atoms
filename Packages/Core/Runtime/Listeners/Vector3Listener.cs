using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Vector3`. Inherits from `AtomListener&lt;Vector3, Vector3Action, Vector3Variable, Vector3Event, Vector3Vector3Event, Vector3Vector3Function, Vector3VariableInstancer, Vector3EventReference, Vector3UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3 Listener")]
    public sealed class Vector3Listener : AtomListener<
        Vector3,
        Vector3Action,
        Vector3Variable,
        Vector3Event,
        Vector3Vector3Event,
        Vector3Vector3Function,
        Vector3VariableInstancer,
        Vector3EventReference,
        Vector3UnityEvent>
    { }
}