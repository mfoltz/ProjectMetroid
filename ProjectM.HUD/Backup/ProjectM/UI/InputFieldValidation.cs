// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InputFieldValidation
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  public static class InputFieldValidation : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Boolean_TMP_InputField_LocalizationKey_byref_LocalizationKey_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1266899, RefRangeEnd = 1266903, XrefRangeStart = 1266897, XrefRangeEnd = 1266899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Validate(
      TMP_InputField inputField,
      LocalizationKey errorAllSpaces,
      out LocalizationKey error)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &errorAllSpaces;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref error;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFieldValidation.NativeMethodInfoPtr_Validate_Internal_Static_Boolean_TMP_InputField_LocalizationKey_byref_LocalizationKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InputFieldValidation()
    {
      Il2CppClassPointerStore<InputFieldValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InputFieldValidation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldValidation>.NativeClassPtr);
      InputFieldValidation.NativeMethodInfoPtr_Validate_Internal_Static_Boolean_TMP_InputField_LocalizationKey_byref_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldValidation>.NativeClassPtr, 100667647);
    }

    public InputFieldValidation(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
