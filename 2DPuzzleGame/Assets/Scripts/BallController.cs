using UnityEngine;
using UnityEngine.EventSystems;

public class BallController : MonoBehaviour, IPointerClickHandler
{
    private SpriteRenderer m_spriteRenderer = null;
    private Rigidbody2D m_rigidbody2D = null;
    Vector2 m_currentVelocity = Vector2.zero;

    bool m_MoveLimit = false;

    private void Awake()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        m_spriteRenderer.gameObject.SetActive(false);
    }
}
