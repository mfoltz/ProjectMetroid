// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkMapZoneDiscoverables
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkMapZoneDiscoverables : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Discoveries;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkMapZoneDiscoverables()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneDiscoverables.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkMapZoneDiscoverables()
    {
      Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkMapZoneDiscoverables));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr);
      ChunkMapZoneDiscoverables.NativeFieldInfoPtr_Discoveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr, nameof (Discoveries));
      ChunkMapZoneDiscoverables.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr, 100667791);
    }

    public ChunkMapZoneDiscoverables(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ChunkMapZoneDiscoverables.DiscoveryElement> Discoveries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.NativeFieldInfoPtr_Discoveries));
        return pointer == System.IntPtr.Zero ? (List<ChunkMapZoneDiscoverables.DiscoveryElement>) null : new List<ChunkMapZoneDiscoverables.DiscoveryElement>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.NativeFieldInfoPtr_Discoveries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class DiscoveryElement : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_DiscoveredFromStart;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DiscoveryElement()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneDiscoverables.DiscoveryElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DiscoveryElement()
      {
        Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkMapZoneDiscoverables>.NativeClassPtr, nameof (DiscoveryElement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr);
        ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr, nameof (Prefab));
        ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_DiscoveredFromStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr, nameof (DiscoveredFromStart));
        ChunkMapZoneDiscoverables.DiscoveryElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneDiscoverables.DiscoveryElement>.NativeClassPtr, 100667792);
      }

      public DiscoveryElement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<PrefabGuidComponent> Prefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_Prefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool DiscoveredFromStart
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_DiscoveredFromStart));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkMapZoneDiscoverables.DiscoveryElement.NativeFieldInfoPtr_DiscoveredFromStart)) = value;
        }
      }
    }
  }
}
