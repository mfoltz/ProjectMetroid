// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldVFXSpawn
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class WorldVFXSpawn : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnedVisualEffect;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXSpawnTranslationOffsets;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCooldownOffsetRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCooldown;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084819, XrefRangeEnd = 1084828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldVFXSpawn.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldVFXSpawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldVFXSpawn()
    {
      Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldVFXSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr);
      WorldVFXSpawn.NativeFieldInfoPtr_SpawnedVisualEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, nameof (SpawnedVisualEffect));
      WorldVFXSpawn.NativeFieldInfoPtr_VFXSpawnTranslationOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, nameof (VFXSpawnTranslationOffsets));
      WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldownOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, nameof (SpawnCooldownOffsetRange));
      WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, nameof (SpawnCooldown));
      WorldVFXSpawn.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, 100685448);
      WorldVFXSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSpawn>.NativeClassPtr, 100685449);
    }

    public WorldVFXSpawn(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject SpawnedVisualEffect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnedVisualEffect));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnedVisualEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<float3> VFXSpawnTranslationOffsets
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_VFXSpawnTranslationOffsets));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float3>) null : new Il2CppStructArray<float3>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_VFXSpawnTranslationOffsets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float2 SpawnCooldownOffsetRange
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldownOffsetRange));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldownOffsetRange)) = value;
      }
    }

    public unsafe float SpawnCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawn.NativeFieldInfoPtr_SpawnCooldown)) = value;
      }
    }
  }
}
