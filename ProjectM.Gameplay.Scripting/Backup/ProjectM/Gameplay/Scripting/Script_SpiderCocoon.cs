// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SpiderCocoon
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_SpiderCocoon : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnChance;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnList;
    private static readonly IntPtr NativeFieldInfoPtr_IsProximityActivated;
    private static readonly IntPtr NativeFieldInfoPtr_IsProximityActivatedChance;
    private static readonly IntPtr NativeFieldInfoPtr_ProximityRadius;
    private static readonly IntPtr NativeFieldInfoPtr_ProximityActivationTime;
    private static readonly IntPtr NativeFieldInfoPtr_LifetimeBuff;
    private static readonly IntPtr NativeFieldInfoPtr_ActivatedSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185577, XrefRangeEnd = 1185603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SpiderCocoon.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185603, XrefRangeEnd = 1185613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SpiderCocoon.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SpiderCocoon()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SpiderCocoon()
    {
      Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SpiderCocoon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr);
      Script_SpiderCocoon.NativeFieldInfoPtr_SpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (SpawnChance));
      Script_SpiderCocoon.NativeFieldInfoPtr_SpawnList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (SpawnList));
      Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (IsProximityActivated));
      Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivatedChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (IsProximityActivatedChance));
      Script_SpiderCocoon.NativeFieldInfoPtr_ProximityRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (ProximityRadius));
      Script_SpiderCocoon.NativeFieldInfoPtr_ProximityActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (ProximityActivationTime));
      Script_SpiderCocoon.NativeFieldInfoPtr_LifetimeBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (LifetimeBuff));
      Script_SpiderCocoon.NativeFieldInfoPtr_ActivatedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (ActivatedSequence));
      Script_SpiderCocoon.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, 100664457);
      Script_SpiderCocoon.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, 100664458);
      Script_SpiderCocoon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, 100664459);
    }

    public Script_SpiderCocoon(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SpawnChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_SpawnChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_SpawnChance)) = value;
      }
    }

    public unsafe List<PrefabGuidComponent> SpawnList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_SpawnList));
        return pointer == IntPtr.Zero ? (List<PrefabGuidComponent>) null : new List<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_SpawnList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsProximityActivated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivated)) = value;
      }
    }

    public unsafe float IsProximityActivatedChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivatedChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_IsProximityActivatedChance)) = value;
      }
    }

    public unsafe float ProximityRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ProximityRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ProximityRadius)) = value;
      }
    }

    public unsafe float ProximityActivationTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ProximityActivationTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ProximityActivationTime)) = value;
      }
    }

    public unsafe PrefabGuidComponent LifetimeBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_LifetimeBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_LifetimeBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActivatedSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ActivatedSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SpiderCocoon.NativeFieldInfoPtr_ActivatedSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_ExplosionTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0;
      private static readonly IntPtr NativeMethodInfoPtr_Explode_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185500, XrefRangeEnd = 1185510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185510, XrefRangeEnd = 1185523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185523, XrefRangeEnd = 1185536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ExplosionTrigger(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<HitResult> hits)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hits;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr_ExplosionTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185536, XrefRangeEnd = 1185537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Explode(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr_Explode_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185537, XrefRangeEnd = 1185570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664460);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664461);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr_ExplosionTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664462);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr_Explode_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664463);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664464);
        Script_SpiderCocoon.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Server>.NativeClassPtr, 100664465);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185570, XrefRangeEnd = 1185577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpiderCocoon.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpiderCocoon.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_SpiderCocoon.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SpiderCocoon>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpiderCocoon.Client>.NativeClassPtr);
        Script_SpiderCocoon.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Client>.NativeClassPtr, 100664466);
        Script_SpiderCocoon.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpiderCocoon.Client>.NativeClassPtr, 100664467);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
