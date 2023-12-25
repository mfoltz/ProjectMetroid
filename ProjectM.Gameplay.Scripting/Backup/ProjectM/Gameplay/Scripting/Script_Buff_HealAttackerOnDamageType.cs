// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_HealAttackerOnDamageType
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
  public class Script_Buff_HealAttackerOnDamageType : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LeechFactor;
    private static readonly IntPtr NativeFieldInfoPtr_MaxLeech;
    private static readonly IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182988, XrefRangeEnd = 1182991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_HealAttackerOnDamageType.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_HealAttackerOnDamageType()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealAttackerOnDamageType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_HealAttackerOnDamageType()
    {
      Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_HealAttackerOnDamageType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr);
      Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_LeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, nameof (LeechFactor));
      Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_MaxLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, nameof (MaxLeech));
      Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, nameof (DamageType));
      Script_Buff_HealAttackerOnDamageType.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, 100664198);
      Script_Buff_HealAttackerOnDamageType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, 100664199);
    }

    public Script_Buff_HealAttackerOnDamageType(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float LeechFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_LeechFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_LeechFactor)) = value;
      }
    }

    public unsafe float MaxLeech
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_MaxLeech));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_MaxLeech)) = value;
      }
    }

    public unsafe MainDamageType DamageType
    {
      get
      {
        return *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_DamageType));
      }
      [param: In] set
      {
        *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealAttackerOnDamageType.NativeFieldInfoPtr_DamageType)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182957, XrefRangeEnd = 1182973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182973, XrefRangeEnd = 1182988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnDamageTaken(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statChangeEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr);
        Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr, 100664200);
        Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr, 100664201);
        Script_Buff_HealAttackerOnDamageType.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealAttackerOnDamageType.Server>.NativeClassPtr, 100664202);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
