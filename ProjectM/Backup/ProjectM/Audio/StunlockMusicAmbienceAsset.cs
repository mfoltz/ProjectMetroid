// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StunlockMusicAmbienceAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Audio
{
  public class StunlockMusicAmbienceAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Track;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunlockMusicAmbienceAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunlockMusicAmbienceAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunlockMusicAmbienceAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunlockMusicAmbienceAsset()
    {
      Il2CppClassPointerStore<StunlockMusicAmbienceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StunlockMusicAmbienceAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunlockMusicAmbienceAsset>.NativeClassPtr);
      StunlockMusicAmbienceAsset.NativeFieldInfoPtr_Track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunlockMusicAmbienceAsset>.NativeClassPtr, nameof (Track));
      StunlockMusicAmbienceAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockMusicAmbienceAsset>.NativeClassPtr, 100690595);
    }

    public StunlockMusicAmbienceAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Track
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockMusicAmbienceAsset.NativeFieldInfoPtr_Track));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockMusicAmbienceAsset.NativeFieldInfoPtr_Track)) = value;
      }
    }
  }
}
