// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_AbilityThrowTowardsEventHitTarget
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_AbilityThrowTowardsEventHitTarget : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ThrowComponent;
    private static readonly IntPtr NativeFieldInfoPtr_Count;
    private static readonly IntPtr NativeFieldInfoPtr_RandomHitRadius;
    private static readonly IntPtr NativeFieldInfoPtr_SetStartPositionToTarget;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176641, XrefRangeEnd = 1176649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_AbilityThrowTowardsEventHitTarget.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_AbilityThrowTowardsEventHitTarget()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_AbilityThrowTowardsEventHitTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_AbilityThrowTowardsEventHitTarget()
    {
      Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_AbilityThrowTowardsEventHitTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr);
      Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_ThrowComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (ThrowComponent));
      Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (Count));
      Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_RandomHitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (RandomHitRadius));
      Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SetStartPositionToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (SetStartPositionToTarget));
      Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (SpawnOffset));
      Script_AbilityThrowTowardsEventHitTarget.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, 100663565);
      Script_AbilityThrowTowardsEventHitTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, 100663566);
    }

    public Script_AbilityThrowTowardsEventHitTarget(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ThrowComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_ThrowComponent));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_ThrowComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float RandomHitRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_RandomHitRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_RandomHitRadius)) = value;
      }
    }

    public unsafe bool SetStartPositionToTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SetStartPositionToTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SetStartPositionToTarget)) = value;
      }
    }

    public unsafe float3 SpawnOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SpawnOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityThrowTowardsEventHitTarget.NativeFieldInfoPtr_SpawnOffset)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176618, XrefRangeEnd = 1176641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnHit(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref gameplayEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityThrowTowardsEventHitTarget.Server.NativeMethodInfoPtr_OnHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityThrowTowardsEventHitTarget.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Server>.NativeClassPtr);
        Script_AbilityThrowTowardsEventHitTarget.Server.NativeMethodInfoPtr_OnHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Server>.NativeClassPtr, 100663567);
        Script_AbilityThrowTowardsEventHitTarget.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Server>.NativeClassPtr, 100663568);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityThrowTowardsEventHitTarget.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Client>.NativeClassPtr);
        Script_AbilityThrowTowardsEventHitTarget.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityThrowTowardsEventHitTarget.Client>.NativeClassPtr, 100663569);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
