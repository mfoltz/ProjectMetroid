// Decompiled with JetBrains decompiler
// Type: StunShared.UI.PlayerPrefsUtils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace StunShared.UI
{
  public static class PlayerPrefsUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 719889, RefRangeEnd = 719896, XrefRangeStart = 719888, XrefRangeEnd = 719889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetBool(string key, bool defaultValue = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPrefsUtils.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 719897, RefRangeEnd = 719905, XrefRangeStart = 719896, XrefRangeEnd = 719897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBool(string key, bool val)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerPrefsUtils.NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerPrefsUtils()
    {
      Il2CppClassPointerStore<PlayerPrefsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (PlayerPrefsUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsUtils>.NativeClassPtr);
      PlayerPrefsUtils.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsUtils>.NativeClassPtr, 100663631);
      PlayerPrefsUtils.NativeMethodInfoPtr_SetBool_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsUtils>.NativeClassPtr, 100663632);
    }

    public PlayerPrefsUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
