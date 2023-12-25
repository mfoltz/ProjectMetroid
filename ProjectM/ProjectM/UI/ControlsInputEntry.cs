// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ControlsInputEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ControlsInputEntry : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryKeyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryKeyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr__Positive;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnalogInput;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnClick;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrimaryButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SecondaryButtonClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInputName_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInputName_Public_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInputName_Private_Void_InputFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInputName_Private_Void_AnalogInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrimary_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrimary_Public_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSecondary_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSecondary_Public_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSecondary_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_InputFlag_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_AnalogInput_Boolean_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160809, XrefRangeEnd = 1160823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160823, XrefRangeEnd = 1160826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrimaryButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_PrimaryButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160826, XrefRangeEnd = 1160829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SecondaryButtonClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SecondaryButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160829, XrefRangeEnd = 1160830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInputName(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160830, XrefRangeEnd = 1160832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInputName(LocalizationKey loc)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &loc;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160832, XrefRangeEnd = 1160838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInputName(InputFlag inputFlag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputFlag;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Private_Void_InputFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160838, XrefRangeEnd = 1160844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInputName(AnalogInput analogInput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &analogInput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Private_Void_AnalogInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160849, RefRangeEnd = 1160851, XrefRangeStart = 1160844, XrefRangeEnd = 1160849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrimary(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetPrimary_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160857, RefRangeEnd = 1160859, XrefRangeStart = 1160851, XrefRangeEnd = 1160857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrimary(Sprite sprite)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetPrimary_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160864, RefRangeEnd = 1160866, XrefRangeStart = 1160859, XrefRangeEnd = 1160864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSecondary(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetSecondary_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160872, RefRangeEnd = 1160873, XrefRangeStart = 1160866, XrefRangeEnd = 1160872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSecondary(Sprite sprite)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetSecondary_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160873, XrefRangeEnd = 1160878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearSecondary()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_ClearSecondary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160881, RefRangeEnd = 1160882, XrefRangeStart = 1160878, XrefRangeEnd = 1160881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      InputSystem inputSystem,
      InputFlag inputFlag,
      Il2CppSystem.Action<ControlsInputEntry, bool, InputFlag, AnalogInput, bool> onClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_InputFlag_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160885, RefRangeEnd = 1160886, XrefRangeStart = 1160882, XrefRangeEnd = 1160885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      InputSystem inputSystem,
      AnalogInput inputFlag,
      bool positive,
      Il2CppSystem.Action<ControlsInputEntry, bool, InputFlag, AnalogInput, bool> onClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_AnalogInput_Boolean_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1160931, RefRangeEnd = 1160935, XrefRangeStart = 1160886, XrefRangeEnd = 1160931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControlsInputEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsInputEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ControlsInputEntry()
    {
      Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (ControlsInputEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr);
      ControlsInputEntry.NativeFieldInfoPtr_InputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (InputName));
      ControlsInputEntry.NativeFieldInfoPtr_PrimaryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (PrimaryButton));
      ControlsInputEntry.NativeFieldInfoPtr_PrimaryKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (PrimaryKeyName));
      ControlsInputEntry.NativeFieldInfoPtr_PrimaryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (PrimaryIcon));
      ControlsInputEntry.NativeFieldInfoPtr_SecondaryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (SecondaryButton));
      ControlsInputEntry.NativeFieldInfoPtr_SecondaryKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (SecondaryKeyName));
      ControlsInputEntry.NativeFieldInfoPtr_SecondaryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (SecondaryIcon));
      ControlsInputEntry.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (_InputSystem));
      ControlsInputEntry.NativeFieldInfoPtr__InputFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (_InputFlag));
      ControlsInputEntry.NativeFieldInfoPtr__Positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (_Positive));
      ControlsInputEntry.NativeFieldInfoPtr__AnalogInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (_AnalogInput));
      ControlsInputEntry.NativeFieldInfoPtr__OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, nameof (_OnClick));
      ControlsInputEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692302);
      ControlsInputEntry.NativeMethodInfoPtr_PrimaryButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692303);
      ControlsInputEntry.NativeMethodInfoPtr_SecondaryButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692304);
      ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692305);
      ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692306);
      ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Private_Void_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692307);
      ControlsInputEntry.NativeMethodInfoPtr_SetInputName_Private_Void_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692308);
      ControlsInputEntry.NativeMethodInfoPtr_SetPrimary_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692309);
      ControlsInputEntry.NativeMethodInfoPtr_SetPrimary_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692310);
      ControlsInputEntry.NativeMethodInfoPtr_SetSecondary_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692311);
      ControlsInputEntry.NativeMethodInfoPtr_SetSecondary_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692312);
      ControlsInputEntry.NativeMethodInfoPtr_ClearSecondary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692313);
      ControlsInputEntry.NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_InputFlag_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692314);
      ControlsInputEntry.NativeMethodInfoPtr_SetData_Internal_Void_InputSystem_AnalogInput_Boolean_Action_5_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692315);
      ControlsInputEntry.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692316);
      ControlsInputEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsInputEntry>.NativeClassPtr, 100692317);
    }

    public ControlsInputEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText InputName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_InputName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_InputName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton PrimaryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PrimaryKeyName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryKeyName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryKeyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image PrimaryIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_PrimaryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SecondaryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SecondaryKeyName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryKeyName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryKeyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SecondaryIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr_SecondaryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputFlag _InputFlag
    {
      get
      {
        return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__InputFlag));
      }
      [param: In] set
      {
        *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__InputFlag)) = value;
      }
    }

    public unsafe bool _Positive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__Positive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__Positive)) = value;
      }
    }

    public unsafe AnalogInput _AnalogInput
    {
      get
      {
        return *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__AnalogInput));
      }
      [param: In] set
      {
        *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__AnalogInput)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<ControlsInputEntry, bool, InputFlag, AnalogInput, bool> _OnClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__OnClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ControlsInputEntry, bool, InputFlag, AnalogInput, bool>) null : new Il2CppSystem.Action<ControlsInputEntry, bool, InputFlag, AnalogInput, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsInputEntry.NativeFieldInfoPtr__OnClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
