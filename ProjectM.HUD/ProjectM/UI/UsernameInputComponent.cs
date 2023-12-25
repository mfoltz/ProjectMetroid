// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UsernameInputComponent
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
  public class UsernameInputComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UserNameInputField;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_onDeselect_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_nameChanged_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288344, XrefRangeEnd = 1288381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UsernameInputComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288381, XrefRangeEnd = 1288403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void onDeselect(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UsernameInputComponent.NativeMethodInfoPtr_onDeselect_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288403, XrefRangeEnd = 1288416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void nameChanged(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UsernameInputComponent.NativeMethodInfoPtr_nameChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UsernameInputComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UsernameInputComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UsernameInputComponent()
    {
      Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UsernameInputComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr);
      UsernameInputComponent.NativeFieldInfoPtr_UserNameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr, nameof (UserNameInputField));
      UsernameInputComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr, 100669661);
      UsernameInputComponent.NativeMethodInfoPtr_onDeselect_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr, 100669662);
      UsernameInputComponent.NativeMethodInfoPtr_nameChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr, 100669663);
      UsernameInputComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsernameInputComponent>.NativeClassPtr, 100669664);
    }

    public UsernameInputComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_InputField UserNameInputField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UsernameInputComponent.NativeFieldInfoPtr_UserNameInputField));
        return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UsernameInputComponent.NativeFieldInfoPtr_UserNameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
