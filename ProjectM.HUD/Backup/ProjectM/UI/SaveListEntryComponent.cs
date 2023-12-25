// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SaveListEntryComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SaveListEntryComponent : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Background;
    private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_DateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeselectSound;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedDateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__Name;
    private static readonly System.IntPtr NativeFieldInfoPtr__CacheddDateTimeString;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnClick;
    private static readonly System.IntPtr NativeFieldInfoPtr__Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectSound;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeselectSound;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_String_DateTime_Boolean_Action_2_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286825, XrefRangeEnd = 1286827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveListEntryComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286827, XrefRangeEnd = 1286843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveListEntryComponent.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286853, RefRangeEnd = 1286854, XrefRangeStart = 1286843, XrefRangeEnd = 1286853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      string name,
      string description,
      Il2CppSystem.DateTime dateTime,
      bool selected,
      Il2CppSystem.Action<bool, int> onClick = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(description);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dateTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &selected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_String_String_DateTime_Boolean_Action_2_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286854, XrefRangeEnd = 1286857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveListEntryComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveListEntryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SaveListEntryComponent()
    {
      Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SaveListEntryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr);
      SaveListEntryComponent.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (Background));
      SaveListEntryComponent.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (Selected));
      SaveListEntryComponent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (Name));
      SaveListEntryComponent.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (Description));
      SaveListEntryComponent.NativeFieldInfoPtr_DateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (DateTime));
      SaveListEntryComponent.NativeFieldInfoPtr_SelectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (SelectSound));
      SaveListEntryComponent.NativeFieldInfoPtr_DeselectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (DeselectSound));
      SaveListEntryComponent.NativeFieldInfoPtr__CachedDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_CachedDateTime));
      SaveListEntryComponent.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_Name));
      SaveListEntryComponent.NativeFieldInfoPtr__CacheddDateTimeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_CacheddDateTimeString));
      SaveListEntryComponent.NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (OnClick));
      SaveListEntryComponent.NativeFieldInfoPtr__Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_Selected));
      SaveListEntryComponent.NativeFieldInfoPtr__SelectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_SelectSound));
      SaveListEntryComponent.NativeFieldInfoPtr__DeselectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, nameof (_DeselectSound));
      SaveListEntryComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, 100669485);
      SaveListEntryComponent.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, 100669486);
      SaveListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_String_String_DateTime_Boolean_Action_2_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, 100669487);
      SaveListEntryComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, 100669488);
      SaveListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveListEntryComponent>.NativeClassPtr, 100669489);
    }

    public SaveListEntryComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Background
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Background));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Selected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Selected));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Description));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text DateTime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_DateTime));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_DateTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent SelectSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_SelectSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_SelectSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent DeselectSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_DeselectSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_DeselectSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppSystem.DateTime _CachedDateTime
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__CachedDateTime));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__CachedDateTime)) = value;
      }
    }

    public unsafe string _Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _CacheddDateTimeString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__CacheddDateTimeString)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__CacheddDateTimeString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.Action<bool, int> OnClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_OnClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool, int>) null : new Il2CppSystem.Action<bool, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr_OnClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Selected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__Selected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__Selected)) = value;
      }
    }

    public unsafe FmodEventGuid _SelectSound
    {
      get
      {
        return *(FmodEventGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__SelectSound));
      }
      [param: In] set
      {
        *(FmodEventGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__SelectSound)) = value;
      }
    }

    public unsafe FmodEventGuid _DeselectSound
    {
      get
      {
        return *(FmodEventGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__DeselectSound));
      }
      [param: In] set
      {
        *(FmodEventGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryComponent.NativeFieldInfoPtr__DeselectSound)) = value;
      }
    }
  }
}
