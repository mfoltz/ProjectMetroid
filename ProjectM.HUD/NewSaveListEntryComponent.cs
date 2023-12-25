// Decompiled with JetBrains decompiler
// Type: NewSaveListEntryComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using StunShared.UI;
using System.Runtime.InteropServices;

#nullable disable
public class NewSaveListEntryComponent : UIEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Button;
  private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_CorruptedText;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameModeText;
  private static readonly System.IntPtr NativeFieldInfoPtr_LastSaved;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloudSaveButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_Data;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Action_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_SaveListEntryData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208815, RefRangeEnd = 1208816, XrefRangeStart = 1208795, XrefRangeEnd = 1208815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(Il2CppSystem.Action onClick, Il2CppSystem.Action onDoubleClick)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onDoubleClick);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.NativeMethodInfoPtr_Initialize_Public_Void_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208838, RefRangeEnd = 1208839, XrefRangeStart = 1208816, XrefRangeEnd = 1208838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(SaveListEntryData uiData, bool isSelected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uiData));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSelected;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.NativeMethodInfoPtr_RefreshData_Public_Void_SaveListEntryData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NewSaveListEntryComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NewSaveListEntryComponent()
  {
    Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (NewSaveListEntryComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr);
    NewSaveListEntryComponent.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (Button));
    NewSaveListEntryComponent.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (NameText));
    NewSaveListEntryComponent.NativeFieldInfoPtr_CorruptedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (CorruptedText));
    NewSaveListEntryComponent.NativeFieldInfoPtr_GameModeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (GameModeText));
    NewSaveListEntryComponent.NativeFieldInfoPtr_LastSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (LastSaved));
    NewSaveListEntryComponent.NativeFieldInfoPtr_CloudSaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (CloudSaveButton));
    NewSaveListEntryComponent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, nameof (Data));
    NewSaveListEntryComponent.NativeMethodInfoPtr_Initialize_Public_Void_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, 100663544);
    NewSaveListEntryComponent.NativeMethodInfoPtr_RefreshData_Public_Void_SaveListEntryData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, 100663545);
    NewSaveListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, 100663546);
  }

  public NewSaveListEntryComponent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SimpleStunButton Button
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_Button));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText NameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_NameText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText CorruptedText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_CorruptedText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_CorruptedText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText GameModeText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_GameModeText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_GameModeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText LastSaved
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_LastSaved));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_LastSaved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton CloudSaveButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_CloudSaveButton));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_CloudSaveButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public SaveListEntryData Data
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_Data);
      return new SaveListEntryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.NativeFieldInfoPtr_Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  [ObfuscatedName("NewSaveListEntryComponent/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_onClick;
    private static readonly System.IntPtr NativeFieldInfoPtr_onDoubleClick;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208791, XrefRangeEnd = 1208793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208793, XrefRangeEnd = 1208795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewSaveListEntryComponent>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr);
      NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr, nameof (onClick));
      NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onDoubleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr, nameof (onDoubleClick));
      NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr, 100663547);
      NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr, 100663548);
      NewSaveListEntryComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewSaveListEntryComponent.__c__DisplayClass7_0>.NativeClassPtr, 100663549);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action onClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action onDoubleClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onDoubleClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewSaveListEntryComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_onDoubleClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
