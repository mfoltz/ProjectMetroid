// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_MoveToBusStop
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
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Buff_MoveToBusStop : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BusStopName;
    private static readonly IntPtr NativeFieldInfoPtr_Speed_Base;
    private static readonly IntPtr NativeFieldInfoPtr_Speed_Variation;
    private static readonly IntPtr NativeFieldInfoPtr_MaxOffsetDistance;
    private static readonly IntPtr NativeFieldInfoPtr_TargetDestroyBuff;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyDistance;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Err_Private_Static_Void_byref_ServerGameManager_Entity_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183616, XrefRangeEnd = 1183621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_MoveToBusStop.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1183631, RefRangeEnd = 1183634, XrefRangeStart = 1183621, XrefRangeEnd = 1183631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Err(ref ServerGameManager game, Entity entity, string message)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) ref game;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.NativeMethodInfoPtr_Err_Private_Static_Void_byref_ServerGameManager_Entity_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_MoveToBusStop()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_MoveToBusStop()
    {
      Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_MoveToBusStop));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr);
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_BusStopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (BusStopName));
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (Speed_Base));
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Variation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (Speed_Variation));
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_MaxOffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (MaxOffsetDistance));
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_TargetDestroyBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (TargetDestroyBuff));
      Script_Buff_MoveToBusStop.NativeFieldInfoPtr_DestroyDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (DestroyDistance));
      Script_Buff_MoveToBusStop.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, 100664246);
      Script_Buff_MoveToBusStop.NativeMethodInfoPtr_Err_Private_Static_Void_byref_ServerGameManager_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, 100664247);
      Script_Buff_MoveToBusStop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, 100664248);
    }

    public Script_Buff_MoveToBusStop(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string BusStopName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_BusStopName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_BusStopName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float Speed_Base
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Base));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Base)) = value;
      }
    }

    public unsafe float Speed_Variation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Variation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_Speed_Variation)) = value;
      }
    }

    public unsafe float MaxOffsetDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_MaxOffsetDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_MaxOffsetDistance)) = value;
      }
    }

    public unsafe WeakAssetReference<BuffComponent> TargetDestroyBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_TargetDestroyBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<BuffComponent>) null : new WeakAssetReference<BuffComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_TargetDestroyBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DestroyDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_DestroyDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_MoveToBusStop.NativeFieldInfoPtr_DestroyDistance)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeFieldInfoPtr_PRUNE_FREQUENCY;
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_DestroySelf_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Buff_MoveToBusStop_DataServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_TryPruneDetour_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_TryFindPath_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_NativeList_1_float3_0;
      private static readonly IntPtr NativeMethodInfoPtr_SpawnPatrol_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeList_1_float3_0;
      private static readonly IntPtr NativeMethodInfoPtr_ApplyDestroyBuffToBuffTarget_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183300, XrefRangeEnd = 1183312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183312, XrefRangeEnd = 1183343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1183367, RefRangeEnd = 1183369, XrefRangeStart = 1183343, XrefRangeEnd = 1183367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void DestroySelf(
        ref ServerGameManager game,
        SelfServer self,
        ref Script_Buff_MoveToBusStop_DataServer data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_DestroySelf_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Buff_MoveToBusStop_DataServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183369, XrefRangeEnd = 1183373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Destroy_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1183419, RefRangeEnd = 1183420, XrefRangeStart = 1183373, XrefRangeEnd = 1183419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void TryPruneDetour(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_TryPruneDetour_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1183492, RefRangeEnd = 1183493, XrefRangeStart = 1183420, XrefRangeEnd = 1183492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryFindPath(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        out NativeList<float3> result)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref result;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_TryFindPath_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_NativeList_1_float3_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1183594, RefRangeEnd = 1183595, XrefRangeStart = 1183493, XrefRangeEnd = 1183594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnPatrol(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeList<float3> path)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &path;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_SpawnPatrol_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeList_1_float3_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183595, XrefRangeEnd = 1183616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ApplyDestroyBuffToBuffTarget(
        ref ServerGameManager game,
        [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_ApplyDestroyBuffToBuffTarget_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_MoveToBusStop>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr);
        Script_Buff_MoveToBusStop.Server.NativeFieldInfoPtr_PRUNE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, nameof (PRUNE_FREQUENCY));
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664249);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664250);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_DestroySelf_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Buff_MoveToBusStop_DataServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664251);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_Destroy_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664252);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_TryPruneDetour_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664253);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_TryFindPath_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_NativeList_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664254);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_SpawnPatrol_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeList_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664255);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr_ApplyDestroyBuffToBuffTarget_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664256);
        Script_Buff_MoveToBusStop.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_MoveToBusStop.Server>.NativeClassPtr, 100664257);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe float PRUNE_FREQUENCY
      {
        get
        {
          float pruneFrequency;
          IL2CPP.il2cpp_field_static_get_value(Script_Buff_MoveToBusStop.Server.NativeFieldInfoPtr_PRUNE_FREQUENCY, (void*) &pruneFrequency);
          return pruneFrequency;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Script_Buff_MoveToBusStop.Server.NativeFieldInfoPtr_PRUNE_FREQUENCY, (void*) &value);
        }
      }
    }
  }
}
