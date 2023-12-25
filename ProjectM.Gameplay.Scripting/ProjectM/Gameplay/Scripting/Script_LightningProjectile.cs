// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_LightningProjectile
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_LightningProjectile : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinAnglePerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAnglePerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRangeForAngleChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRangeForAngleChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177795, XrefRangeEnd = 1177807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_LightningProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177807, XrefRangeEnd = 1177814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_LightningProjectile.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177814, XrefRangeEnd = 1177815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_LightningProjectile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_LightningProjectile()
    {
      Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_LightningProjectile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr);
      Script_LightningProjectile.NativeFieldInfoPtr_MinAnglePerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (MinAnglePerNode));
      Script_LightningProjectile.NativeFieldInfoPtr_MaxAnglePerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (MaxAnglePerNode));
      Script_LightningProjectile.NativeFieldInfoPtr_MinRangeForAngleChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (MinRangeForAngleChange));
      Script_LightningProjectile.NativeFieldInfoPtr_MaxRangeForAngleChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (MaxRangeForAngleChange));
      Script_LightningProjectile.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (Range));
      Script_LightningProjectile.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (Speed));
      Script_LightningProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, 100663655);
      Script_LightningProjectile.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, 100663656);
      Script_LightningProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, 100663657);
    }

    public Script_LightningProjectile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinAnglePerNode
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MinAnglePerNode));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MinAnglePerNode)) = value;
      }
    }

    public unsafe float MaxAnglePerNode
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MaxAnglePerNode));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MaxAnglePerNode)) = value;
      }
    }

    public unsafe float MinRangeForAngleChange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MinRangeForAngleChange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MinRangeForAngleChange)) = value;
      }
    }

    public unsafe float MaxRangeForAngleChange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MaxRangeForAngleChange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_MaxRangeForAngleChange)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_LightningProjectile.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177684, XrefRangeEnd = 1177705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177705, XrefRangeEnd = 1177753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr);
        Script_LightningProjectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr, 100663658);
        Script_LightningProjectile.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr, 100663659);
        Script_LightningProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Server>.NativeClassPtr, 100663660);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Shared : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_Script_LightningProjectile_DataShared_LifeTime_Age_DynamicBuffer_1_Script_LightningProjectile_Nodes_byref_Translation_byref_LastTranslation_byref_Rotation_Color_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1177773, RefRangeEnd = 1177775, XrefRangeStart = 1177753, XrefRangeEnd = 1177773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void UpdateMovement(
        Script_LightningProjectile_DataShared data,
        LifeTime lifeTime,
        Age age,
        DynamicBuffer<Script_LightningProjectile_Nodes> nodes,
        ref Translation translation,
        ref LastTranslation lastTranslation,
        ref Rotation rotation,
        Color debugColor)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodes;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &debugColor;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Shared.NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_Script_LightningProjectile_DataShared_LifeTime_Age_DynamicBuffer_1_Script_LightningProjectile_Nodes_byref_Translation_byref_LastTranslation_byref_Rotation_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Shared()
      {
        Il2CppClassPointerStore<Script_LightningProjectile.Shared>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (Shared));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile.Shared>.NativeClassPtr);
        Script_LightningProjectile.Shared.NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_Script_LightningProjectile_DataShared_LifeTime_Age_DynamicBuffer_1_Script_LightningProjectile_Nodes_byref_Translation_byref_LastTranslation_byref_Rotation_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Shared>.NativeClassPtr, 100663661);
      }

      public Shared(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177775, XrefRangeEnd = 1177795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_LightningProjectile.Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_LightningProjectile.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_LightningProjectile.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_LightningProjectile>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile.Client>.NativeClassPtr);
        Script_LightningProjectile.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Client>.NativeClassPtr, 100663662);
        Script_LightningProjectile.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_LightningProjectile.Client>.NativeClassPtr, 100663663);
      }

      public Client(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
