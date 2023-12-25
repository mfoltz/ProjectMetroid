// Decompiled with JetBrains decompiler
// Type: ProjectM.DisableWhenNoPlayersInRangeSystem_Debug
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class DisableWhenNoPlayersInRangeSystem_Debug : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDisableSystemDisabled_Public_Static_Void_World_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053381, RefRangeEnd = 1053382, XrefRangeStart = 1053378, XrefRangeEnd = 1053381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetDisableSystemDisabled(World world, bool enabled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem_Debug.NativeMethodInfoPtr_SetDisableSystemDisabled_Public_Static_Void_World_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DisableWhenNoPlayersInRangeSystem_Debug()
    {
      Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem_Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DisableWhenNoPlayersInRangeSystem_Debug));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem_Debug>.NativeClassPtr);
      DisableWhenNoPlayersInRangeSystem_Debug.NativeMethodInfoPtr_SetDisableSystemDisabled_Public_Static_Void_World_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem_Debug>.NativeClassPtr, 100682867);
    }

    public DisableWhenNoPlayersInRangeSystem_Debug(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
