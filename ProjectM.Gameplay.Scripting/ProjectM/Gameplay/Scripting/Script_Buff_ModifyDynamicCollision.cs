// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision
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
  public class Script_Buff_ModifyDynamicCollision : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AgainstWhat;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyHardness;
    private static readonly IntPtr NativeFieldInfoPtr_Hardness;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyPushStrengthMin;
    private static readonly IntPtr NativeFieldInfoPtr_PushStrengthMin;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyPushStrengthMax;
    private static readonly IntPtr NativeFieldInfoPtr_PushStrengthMax;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183223, XrefRangeEnd = 1183228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_ModifyDynamicCollision.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_ModifyDynamicCollision()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_ModifyDynamicCollision()
    {
      Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_ModifyDynamicCollision));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr);
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_AgainstWhat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (AgainstWhat));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyHardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (ModifyHardness));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_Hardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (Hardness));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (ModifyPushStrengthMin));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (PushStrengthMin));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (ModifyPushStrengthMax));
      Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (PushStrengthMax));
      Script_Buff_ModifyDynamicCollision.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, 100664229);
      Script_Buff_ModifyDynamicCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, 100664230);
    }

    public Script_Buff_ModifyDynamicCollision(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModifyDynamicCollisionTargets AgainstWhat
    {
      get
      {
        return *(ModifyDynamicCollisionTargets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_AgainstWhat));
      }
      [param: In] set
      {
        *(ModifyDynamicCollisionTargets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_AgainstWhat)) = value;
      }
    }

    public unsafe bool ModifyHardness
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyHardness));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyHardness)) = value;
      }
    }

    public unsafe float Hardness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_Hardness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_Hardness)) = value;
      }
    }

    public unsafe bool ModifyPushStrengthMin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMin)) = value;
      }
    }

    public unsafe float PushStrengthMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMin)) = value;
      }
    }

    public unsafe bool ModifyPushStrengthMax
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMax));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_ModifyPushStrengthMax)) = value;
      }
    }

    public unsafe float PushStrengthMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ModifyDynamicCollision.NativeFieldInfoPtr_PushStrengthMax)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_ApplyModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_SelfServer_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr_RemoveModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1183175, RefRangeEnd = 1183177, XrefRangeStart = 1183168, XrefRangeEnd = 1183175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ApplyModifications(
        ref ServerGameManager game,
        ref DynamicCollisionSettings settings,
        ref Script_Buff_ModifyDynamicCollision_DataServer.Modifications mods,
        ref Script_Buff_ModifyDynamicCollision_DataServer data,
        SelfServer self,
        Entity target)
      {
        IntPtr* numPtr = stackalloc IntPtr[6];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref settings;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref mods;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref data;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &target;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_ApplyModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_SelfServer_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1183187, RefRangeEnd = 1183189, XrefRangeStart = 1183177, XrefRangeEnd = 1183187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RemoveModifications(
        ref ServerGameManager game,
        ref DynamicCollisionSettings settings,
        ref Script_Buff_ModifyDynamicCollision_DataServer.Modifications mods,
        ref Script_Buff_ModifyDynamicCollision_DataServer data,
        Entity target)
      {
        IntPtr* numPtr = stackalloc IntPtr[5];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref settings;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref mods;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref data;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &target;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_RemoveModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183189, XrefRangeEnd = 1183206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183206, XrefRangeEnd = 1183223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr);
        Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_ApplyModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_SelfServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr, 100664231);
        Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_RemoveModifications_Private_Static_Void_byref_ServerGameManager_byref_DynamicCollisionSettings_byref_Modifications_byref_Script_Buff_ModifyDynamicCollision_DataServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr, 100664232);
        Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr, 100664233);
        Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr, 100664234);
        Script_Buff_ModifyDynamicCollision.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision.Server>.NativeClassPtr, 100664235);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
