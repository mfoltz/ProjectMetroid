// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_SpawnThrowTowardsNearbyVampires : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ThrowPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_Count;
    private static readonly IntPtr NativeFieldInfoPtr_MaximumCount;
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetMin;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetMax;
    private static readonly IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189201, XrefRangeEnd = 1189205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SpawnThrowTowardsNearbyVampires.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189205, XrefRangeEnd = 1189206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SpawnThrowTowardsNearbyVampires()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SpawnThrowTowardsNearbyVampires.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SpawnThrowTowardsNearbyVampires()
    {
      Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SpawnThrowTowardsNearbyVampires));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr);
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_ThrowPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (ThrowPrefab));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (Count));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_MaximumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (MaximumCount));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (Radius));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (OffsetMin));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (OffsetMax));
      Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (HitFilter));
      Script_SpawnThrowTowardsNearbyVampires.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, 100664815);
      Script_SpawnThrowTowardsNearbyVampires.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, 100664816);
    }

    public Script_SpawnThrowTowardsNearbyVampires(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ThrowPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_ThrowPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_ThrowPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe int MaximumCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_MaximumCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_MaximumCount)) = value;
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe float OffsetMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMin)) = value;
      }
    }

    public unsafe float OffsetMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_OffsetMax)) = value;
      }
    }

    public unsafe HitFilter HitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_HitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnThrowTowardsNearbyVampires.NativeFieldInfoPtr_HitFilter)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_TriggerHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189154, XrefRangeEnd = 1189167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189167, XrefRangeEnd = 1189201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void TriggerHit(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<HitResult> hits)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hits;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr_TriggerHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr);
        Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr, 100664817);
        Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr_TriggerHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr, 100664818);
        Script_SpawnThrowTowardsNearbyVampires.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires.Server>.NativeClassPtr, 100664819);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
