// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_MultiThrow_Cast
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

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_MultiThrow_Cast : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ThrowComponent;
    private static readonly IntPtr NativeFieldInfoPtr_Count;
    private static readonly IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly IntPtr NativeFieldInfoPtr_UseAimDirection;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177964, XrefRangeEnd = 1177972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_MultiThrow_Cast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177972, XrefRangeEnd = 1177973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_MultiThrow_Cast()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_MultiThrow_Cast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_MultiThrow_Cast()
    {
      Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_MultiThrow_Cast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr);
      Script_MultiThrow_Cast.NativeFieldInfoPtr_ThrowComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (ThrowComponent));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (Count));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (MinRange));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (MaxRange));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (OffsetAngle));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (RandomAngle));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (IndividualRandom));
      Script_MultiThrow_Cast.NativeFieldInfoPtr_UseAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (UseAimDirection));
      Script_MultiThrow_Cast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, 100663673);
      Script_MultiThrow_Cast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, 100663674);
    }

    public Script_MultiThrow_Cast(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ThrowComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_ThrowComponent));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_ThrowComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_MinRange)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public unsafe float OffsetAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_OffsetAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_OffsetAngle)) = value;
      }
    }

    public unsafe float RandomAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_RandomAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_RandomAngle)) = value;
      }
    }

    public unsafe bool IndividualRandom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_IndividualRandom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_IndividualRandom)) = value;
      }
    }

    public unsafe bool UseAimDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_UseAimDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_MultiThrow_Cast.NativeFieldInfoPtr_UseAimDirection)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_MultiThrowSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Script_MultiThrow_Cast_DataServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177918, XrefRangeEnd = 1177922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void MultiThrowSpawn(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_MultiThrow_Cast.Server.NativeMethodInfoPtr_MultiThrowSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1177963, RefRangeEnd = 1177964, XrefRangeStart = 1177922, XrefRangeEnd = 1177963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnCluster(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Script_MultiThrow_Cast_DataServer dataServer)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dataServer;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_MultiThrow_Cast.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Script_MultiThrow_Cast_DataServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_MultiThrow_Cast.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_MultiThrow_Cast>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr);
        Script_MultiThrow_Cast.Server.NativeMethodInfoPtr_MultiThrowSpawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr, 100663675);
        Script_MultiThrow_Cast.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Script_MultiThrow_Cast_DataServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr, 100663676);
        Script_MultiThrow_Cast.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_MultiThrow_Cast.Server>.NativeClassPtr, 100663677);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
