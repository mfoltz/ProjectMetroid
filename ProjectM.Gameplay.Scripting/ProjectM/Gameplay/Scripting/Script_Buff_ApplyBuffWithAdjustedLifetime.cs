// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_ApplyBuffWithAdjustedLifetime
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
  public class Script_Buff_ApplyBuffWithAdjustedLifetime : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DurationMin;
    private static readonly IntPtr NativeFieldInfoPtr_DurationPerLifetimeOfParent;
    private static readonly IntPtr NativeFieldInfoPtr_MaxLifeTime;
    private static readonly IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182601, XrefRangeEnd = 1182605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_ApplyBuffWithAdjustedLifetime.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_ApplyBuffWithAdjustedLifetime()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_ApplyBuffWithAdjustedLifetime()
    {
      Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_ApplyBuffWithAdjustedLifetime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr);
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, nameof (DurationMin));
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationPerLifetimeOfParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, nameof (DurationPerLifetimeOfParent));
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_MaxLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, nameof (MaxLifeTime));
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, nameof (BuffType));
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, 100664155);
      Script_Buff_ApplyBuffWithAdjustedLifetime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, 100664156);
    }

    public Script_Buff_ApplyBuffWithAdjustedLifetime(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DurationMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationMin)) = value;
      }
    }

    public unsafe float DurationPerLifetimeOfParent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationPerLifetimeOfParent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_DurationPerLifetimeOfParent)) = value;
      }
    }

    public unsafe float MaxLifeTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_MaxLifeTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_MaxLifeTime)) = value;
      }
    }

    public unsafe PrefabGuidComponent BuffType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_BuffType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_ApplyBuffWithAdjustedLifetime.NativeFieldInfoPtr_BuffType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182576, XrefRangeEnd = 1182601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnGameplayEvent(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref gameplayEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ApplyBuffWithAdjustedLifetime.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_ApplyBuffWithAdjustedLifetime.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime.Server>.NativeClassPtr);
        Script_Buff_ApplyBuffWithAdjustedLifetime.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime.Server>.NativeClassPtr, 100664157);
        Script_Buff_ApplyBuffWithAdjustedLifetime.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_ApplyBuffWithAdjustedLifetime.Server>.NativeClassPtr, 100664158);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
