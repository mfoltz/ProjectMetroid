// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ActionBarEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ActionBarEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GetInputMapProfilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Overlay;
    private static readonly System.IntPtr NativeFieldInfoPtr_BrokenParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShatteredParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hotkey;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountText;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnBeginDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEndDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDropAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnRightClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnMiddleClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnPointerEnterAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnPointerExitAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_IconBackground_Default;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_IconBackground_Equipped;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentUIState;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodPotionText;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Int32_InputSystem_GameDataSystem_PrefabCollectionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInputFlagFromSlot_Private_Static_InputFlag_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215243, XrefRangeEnd = 1215246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnBeginDrag(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDrag(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215246, XrefRangeEnd = 1215249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDrop(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215249, XrefRangeEnd = 1215252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnEndDrag(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215252, XrefRangeEnd = 1215257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215257, XrefRangeEnd = 1215260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215260, XrefRangeEnd = 1215261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215261, XrefRangeEnd = 1215272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215272, XrefRangeEnd = 1215274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215314, RefRangeEnd = 1215315, XrefRangeStart = 1215274, XrefRangeEnd = 1215314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      ref ActionBarEntry.Data data,
      int entryIndex,
      InputSystem inputSystem,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Int32_InputSystem_GameDataSystem_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215393, RefRangeEnd = 1215394, XrefRangeStart = 1215315, XrefRangeEnd = 1215393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateState(ref ActionBarEntry.UIState newState, InputSystem inputSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newState);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe InputFlag GetInputFlagFromSlot(int entryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr_GetInputFlagFromSlot_Private_Static_InputFlag_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InputFlag*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionBarEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActionBarEntry()
    {
      Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ActionBarEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr);
      ActionBarEntry.NativeFieldInfoPtr__GetInputMapProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (_GetInputMapProfilerMarker));
      ActionBarEntry.NativeFieldInfoPtr_IconBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (IconBackground));
      ActionBarEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Icon));
      ActionBarEntry.NativeFieldInfoPtr_Overlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Overlay));
      ActionBarEntry.NativeFieldInfoPtr_BrokenParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (BrokenParent));
      ActionBarEntry.NativeFieldInfoPtr_ShatteredParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (ShatteredParent));
      ActionBarEntry.NativeFieldInfoPtr_Hotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Hotkey));
      ActionBarEntry.NativeFieldInfoPtr_CountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (CountText));
      ActionBarEntry.NativeFieldInfoPtr_OnBeginDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnBeginDragAction));
      ActionBarEntry.NativeFieldInfoPtr_OnEndDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnEndDragAction));
      ActionBarEntry.NativeFieldInfoPtr_OnDropAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnDropAction));
      ActionBarEntry.NativeFieldInfoPtr_OnRightClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnRightClicked));
      ActionBarEntry.NativeFieldInfoPtr_OnMiddleClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnMiddleClicked));
      ActionBarEntry.NativeFieldInfoPtr_OnPointerEnterAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnPointerEnterAction));
      ActionBarEntry.NativeFieldInfoPtr_OnPointerExitAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (OnPointerExitAction));
      ActionBarEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (EntryId));
      ActionBarEntry.NativeFieldInfoPtr_SyncedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (SyncedEntity));
      ActionBarEntry.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (IsHovered));
      ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Sprite_IconBackground_Default));
      ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Sprite_IconBackground_Equipped));
      ActionBarEntry.NativeFieldInfoPtr__CurrentUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (_CurrentUIState));
      ActionBarEntry.NativeFieldInfoPtr__CurrentItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (_CurrentItemType));
      ActionBarEntry.NativeFieldInfoPtr__CurrentItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (_CurrentItemEntity));
      ActionBarEntry.NativeFieldInfoPtr_BloodPotionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (BloodPotionParent));
      ActionBarEntry.NativeFieldInfoPtr_BloodPotionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (BloodPotionImage));
      ActionBarEntry.NativeFieldInfoPtr_BloodPotionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (BloodPotionText));
      ActionBarEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664087);
      ActionBarEntry.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664088);
      ActionBarEntry.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664089);
      ActionBarEntry.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664090);
      ActionBarEntry.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664091);
      ActionBarEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664092);
      ActionBarEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664093);
      ActionBarEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664094);
      ActionBarEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664095);
      ActionBarEntry.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664096);
      ActionBarEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Int32_InputSystem_GameDataSystem_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664097);
      ActionBarEntry.NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664098);
      ActionBarEntry.NativeMethodInfoPtr_GetInputFlagFromSlot_Private_Static_InputFlag_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664099);
      ActionBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, 100664100);
    }

    public ActionBarEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ProfilerMarker _GetInputMapProfilerMarker
    {
      get
      {
        ProfilerMarker mapProfilerMarker;
        IL2CPP.il2cpp_field_static_get_value(ActionBarEntry.NativeFieldInfoPtr__GetInputMapProfilerMarker, (void*) &mapProfilerMarker);
        return mapProfilerMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ActionBarEntry.NativeFieldInfoPtr__GetInputMapProfilerMarker, (void*) &value);
      }
    }

    public unsafe Image IconBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_IconBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_IconBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Overlay
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Overlay));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Overlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BrokenParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BrokenParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BrokenParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ShatteredParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_ShatteredParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_ShatteredParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Hotkey
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Hotkey));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Hotkey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CountText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_CountText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_CountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnBeginDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnBeginDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnBeginDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnEndDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnEndDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnEndDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnDropAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnDropAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnDropAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnRightClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnRightClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnRightClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnMiddleClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnMiddleClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnMiddleClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnPointerEnterAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnPointerEnterAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnPointerEnterAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnPointerExitAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnPointerExitAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_OnPointerExitAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe Entity SyncedEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_SyncedEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_SyncedEntity)) = value;
      }
    }

    public unsafe bool IsHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_IsHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_IsHovered)) = value;
      }
    }

    public unsafe Sprite Sprite_IconBackground_Default
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Default));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Default), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_IconBackground_Equipped
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Equipped));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_Sprite_IconBackground_Equipped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ActionBarEntry.UIState _CurrentUIState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentUIState);
        return new ActionBarEntry.UIState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentUIState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabGUID _CurrentItemType
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentItemType));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentItemType)) = value;
      }
    }

    public unsafe Entity _CurrentItemEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentItemEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr__CurrentItemEntity)) = value;
      }
    }

    public unsafe GameObject BloodPotionParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BloodPotionImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BloodPotionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.NativeFieldInfoPtr_BloodPotionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SyncedEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      private static readonly System.IntPtr NativeFieldInfoPtr_Equipped;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsBroken;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsShattered;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExtraItemInfo;

      static Data()
      {
        Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr);
        ActionBarEntry.Data.NativeFieldInfoPtr_SyncedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (SyncedEntity));
        ActionBarEntry.Data.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (ItemType));
        ActionBarEntry.Data.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (Type));
        ActionBarEntry.Data.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (Count));
        ActionBarEntry.Data.NativeFieldInfoPtr_Equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (Equipped));
        ActionBarEntry.Data.NativeFieldInfoPtr_IsBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (IsBroken));
        ActionBarEntry.Data.NativeFieldInfoPtr_IsShattered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (IsShattered));
        ActionBarEntry.Data.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (HasData));
        ActionBarEntry.Data.NativeFieldInfoPtr_ExtraItemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, nameof (ExtraItemInfo));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionBarEntry.Data>.NativeClassPtr, data));
      }

      public unsafe Entity SyncedEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_SyncedEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_SyncedEntity)) = value;
        }
      }

      public unsafe ItemType ItemType
      {
        get
        {
          return *(ItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_ItemType));
        }
        [param: In] set
        {
          *(ItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_ItemType)) = value;
        }
      }

      public unsafe PrefabGUID Type
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe int Count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Count)) = value;
        }
      }

      public unsafe bool Equipped
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Equipped));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_Equipped)) = value;
        }
      }

      public unsafe bool IsBroken
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_IsBroken));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_IsBroken)) = value;
        }
      }

      public unsafe bool IsShattered
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_IsShattered));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_IsShattered)) = value;
        }
      }

      public unsafe bool HasData
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_HasData));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_HasData)) = value;
        }
      }

      public Il2CppSystem.Nullable<ExtraItemInfo> ExtraItemInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_ExtraItemInfo);
          return new Il2CppSystem.Nullable<ExtraItemInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.Data.NativeFieldInfoPtr_ExtraItemInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    public sealed class UIState : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IconBackgroundSprite;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverlayColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntryIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputChangeVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      private static readonly System.IntPtr NativeFieldInfoPtr_BrokenParentActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShatteredParentActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_IconActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_CountTextActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExtraItemInfo;

      static UIState()
      {
        Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionBarEntry>.NativeClassPtr, nameof (UIState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr);
        ActionBarEntry.UIState.NativeFieldInfoPtr_IconBackgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (IconBackgroundSprite));
        ActionBarEntry.UIState.NativeFieldInfoPtr_OverlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (OverlayColor));
        ActionBarEntry.UIState.NativeFieldInfoPtr_EntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (EntryIndex));
        ActionBarEntry.UIState.NativeFieldInfoPtr_InputChangeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (InputChangeVersion));
        ActionBarEntry.UIState.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (Count));
        ActionBarEntry.UIState.NativeFieldInfoPtr_BrokenParentActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (BrokenParentActive));
        ActionBarEntry.UIState.NativeFieldInfoPtr_ShatteredParentActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (ShatteredParentActive));
        ActionBarEntry.UIState.NativeFieldInfoPtr_IconActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (IconActive));
        ActionBarEntry.UIState.NativeFieldInfoPtr_CountTextActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (CountTextActive));
        ActionBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (GameObjectActive));
        ActionBarEntry.UIState.NativeFieldInfoPtr_ExtraItemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, nameof (ExtraItemInfo));
      }

      public UIState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UIState()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionBarEntry.UIState>.NativeClassPtr, data));
      }

      public unsafe Sprite IconBackgroundSprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_IconBackgroundSprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_IconBackgroundSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Color OverlayColor
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_OverlayColor));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_OverlayColor)) = value;
        }
      }

      public unsafe int EntryIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_EntryIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_EntryIndex)) = value;
        }
      }

      public unsafe int InputChangeVersion
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_InputChangeVersion));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_InputChangeVersion)) = value;
        }
      }

      public unsafe int Count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_Count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_Count)) = value;
        }
      }

      public unsafe bool BrokenParentActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_BrokenParentActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_BrokenParentActive)) = value;
        }
      }

      public unsafe bool ShatteredParentActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_ShatteredParentActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_ShatteredParentActive)) = value;
        }
      }

      public unsafe bool IconActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_IconActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_IconActive)) = value;
        }
      }

      public unsafe bool CountTextActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_CountTextActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_CountTextActive)) = value;
        }
      }

      public unsafe bool GameObjectActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive)) = value;
        }
      }

      public Il2CppSystem.Nullable<ExtraItemInfo> ExtraItemInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_ExtraItemInfo);
          return new Il2CppSystem.Nullable<ExtraItemInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarEntry.UIState.NativeFieldInfoPtr_ExtraItemInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ExtraItemInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
