// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.MusicUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

#nullable disable
namespace ProjectM.Audio
{
  public static class MusicUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTrack_Public_Static_Void_Nullable_Unboxed_1_MusicAmbienceData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142323, XrefRangeEnd = 1142325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTrack(Nullable_Unboxed<MusicAmbienceData> data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicUtils.NativeMethodInfoPtr_SetTrack_Public_Static_Void_Nullable_Unboxed_1_MusicAmbienceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MusicUtils()
    {
      Il2CppClassPointerStore<MusicUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (MusicUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicUtils>.NativeClassPtr);
      MusicUtils.NativeMethodInfoPtr_SetTrack_Public_Static_Void_Nullable_Unboxed_1_MusicAmbienceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicUtils>.NativeClassPtr, 100690401);
    }

    public MusicUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
