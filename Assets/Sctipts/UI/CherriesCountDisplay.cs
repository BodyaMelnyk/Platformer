using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CherriesCountDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _cherrisCount;
    [SerializeField] private ItemCollector _collector;

    private void OnEnable()
    {
        _collector.ItemCollected += OnItemChanged;
    }

    private void OnDisable()
    {
        _collector.ItemCollected -= OnItemChanged;
    }

    private void OnItemChanged(int item)
    {
        _cherrisCount.text = item.ToString();
    }
}
