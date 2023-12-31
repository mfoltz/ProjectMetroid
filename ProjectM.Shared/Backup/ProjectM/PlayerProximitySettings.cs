// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerProximitySettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PlayerProximitySettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749154, XrefRangeEnd = 749155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerProximitySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerProximitySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerProximitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerProximitySettings()
    {
      Il2CppClassPointerStore<PlayerProximitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PlayerProximitySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerProximitySettings>.NativeClassPtr);
      PlayerProximitySettings.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerProximitySettings>.NativeClassPtr, nameof (Range));
      PlayerProximitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProximitySettings>.NativeClassPtr, 100665971);
    }

    public PlayerProximitySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2Int Range
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerProximitySettings.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerProximitySettings.NativeFieldInfoPtr_Range)) = value;
      }
    }
  }
}
