// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServantCoffinstationSubMenu_ChangeNamePopup
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class ServantCoffinstationSubMenu_ChangeNamePopup : GenericPopup
  {
    private static readonly IntPtr NativeFieldInfoPtr_NameInputField;
    private static readonly IntPtr NativeFieldInfoPtr_RandomizeButton;
    private static readonly IntPtr NativeFieldInfoPtr_MaleServantNames;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleServantNames;
    private static readonly IntPtr NativeFieldInfoPtr_MountNames;
    private static readonly IntPtr NativeFieldInfoPtr_NameStatus;
    private static readonly IntPtr NativeFieldInfoPtr_RandomLocalizationKeys;
    private static readonly IntPtr NativeFieldInfoPtr__Random;
    private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RandomizeServantName_Public_Void_GenderType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRandomServantName_Public_String_GenderType_0;
    private static readonly IntPtr NativeMethodInfoPtr_RandomizeMountName_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__8_0_Private_Void_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248317, XrefRangeEnd = 1248334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnAwake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248334, XrefRangeEnd = 1248345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1248348, RefRangeEnd = 1248349, XrefRangeStart = 1248345, XrefRangeEnd = 1248348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RandomizeServantName(GenderType genderType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &genderType;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_RandomizeServantName_Public_Void_GenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1248376, RefRangeEnd = 1248380, XrefRangeStart = 1248349, XrefRangeEnd = 1248376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetRandomServantName(GenderType genderType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &genderType;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_GetRandomServantName_Public_String_GenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248380, XrefRangeEnd = 1248390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RandomizeMountName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_RandomizeMountName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantCoffinstationSubMenu_ChangeNamePopup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248390, XrefRangeEnd = 1248397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnAwake_b__8_0(string newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newValue);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr__OnAwake_b__8_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantCoffinstationSubMenu_ChangeNamePopup()
    {
      Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServantCoffinstationSubMenu_ChangeNamePopup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (NameInputField));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (RandomizeButton));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MaleServantNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (MaleServantNames));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_FemaleServantNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (FemaleServantNames));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MountNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (MountNames));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (NameStatus));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (RandomLocalizationKeys));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr__Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, nameof (_Random));
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666442);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666443);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_RandomizeServantName_Public_Void_GenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666444);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_GetRandomServantName_Public_String_GenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666445);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr_RandomizeMountName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666446);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666447);
      ServantCoffinstationSubMenu_ChangeNamePopup.NativeMethodInfoPtr__OnAwake_b__8_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ChangeNamePopup>.NativeClassPtr, 100666448);
    }

    public ServantCoffinstationSubMenu_ChangeNamePopup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_InputField NameInputField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameInputField));
        return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RandomizeButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomizeButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomizeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset MaleServantNames
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MaleServantNames));
        return pointer == IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MaleServantNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset FemaleServantNames
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_FemaleServantNames));
        return pointer == IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_FemaleServantNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset MountNames
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MountNames));
        return pointer == IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_MountNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameStatus
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameStatus));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_NameStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RandomLocalizationKeys RandomLocalizationKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomLocalizationKeys));
        return pointer == IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr_RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Unity.Mathematics.Random _Random
    {
      get
      {
        return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr__Random));
      }
      [param: In] set
      {
        *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ChangeNamePopup.NativeFieldInfoPtr__Random)) = value;
      }
    }
  }
}
