// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.CommandLineUtils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public static class CommandLineUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CommandLineArgs;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasParameter_Public_Static_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterString_Public_Static_Boolean_String_byref_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterBool_Public_Static_Boolean_String_byref_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterInt_Public_Static_Boolean_String_byref_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterULong_Public_Static_Boolean_String_byref_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterUInt_Public_Static_Boolean_String_byref_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetParameterUShort_Public_Static_Boolean_String_byref_UInt16_UInt16_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 796966, RefRangeEnd = 796976, XrefRangeStart = 796959, XrefRangeEnd = 796966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasParameter(string parameterName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_HasParameter_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 796995, RefRangeEnd = 797000, XrefRangeStart = 796976, XrefRangeEnd = 796995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterString(
      string parameterName,
      out string parameterValue,
      string defaultValue = "")
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterString_Public_Static_Boolean_String_byref_String_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      parameterValue = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797000, XrefRangeEnd = 797022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterBool(
      string parameterName,
      out bool parameterValue,
      bool defaultValue = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameterValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterBool_Public_Static_Boolean_String_byref_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797022, XrefRangeEnd = 797041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterInt(
      string parameterName,
      out int parameterValue,
      int defaultValue = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameterValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterInt_Public_Static_Boolean_String_byref_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797060, RefRangeEnd = 797061, XrefRangeStart = 797041, XrefRangeEnd = 797060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterULong(
      string parameterName,
      out ulong parameterValue,
      ulong defaultValue = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameterValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterULong_Public_Static_Boolean_String_byref_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797080, RefRangeEnd = 797081, XrefRangeStart = 797061, XrefRangeEnd = 797080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterUInt(
      string parameterName,
      out uint parameterValue,
      uint defaultValue = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameterValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterUInt_Public_Static_Boolean_String_byref_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797081, XrefRangeEnd = 797100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetParameterUShort(
      string parameterName,
      out ushort parameterValue,
      ushort defaultValue = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameterValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandLineUtils.NativeMethodInfoPtr_TryGetParameterUShort_Public_Static_Boolean_String_byref_UInt16_UInt16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CommandLineUtils()
    {
      Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (CommandLineUtils));
      CommandLineUtils.NativeFieldInfoPtr__CommandLineArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, nameof (_CommandLineArgs));
      CommandLineUtils.NativeMethodInfoPtr_HasParameter_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670330);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterString_Public_Static_Boolean_String_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670331);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterBool_Public_Static_Boolean_String_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670332);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterInt_Public_Static_Boolean_String_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670333);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterULong_Public_Static_Boolean_String_byref_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670334);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterUInt_Public_Static_Boolean_String_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670335);
      CommandLineUtils.NativeMethodInfoPtr_TryGetParameterUShort_Public_Static_Boolean_String_byref_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandLineUtils>.NativeClassPtr, 100670336);
    }

    public CommandLineUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppStringArray _CommandLineArgs
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CommandLineUtils.NativeFieldInfoPtr__CommandLineArgs, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CommandLineUtils.NativeFieldInfoPtr__CommandLineArgs, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
