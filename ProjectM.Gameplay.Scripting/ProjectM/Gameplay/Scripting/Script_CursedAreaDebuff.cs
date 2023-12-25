// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CursedAreaDebuff
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
  public class Script_CursedAreaDebuff : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TimerInterval;
    private static readonly IntPtr NativeFieldInfoPtr_DynamicStacksPerTick;
    private static readonly IntPtr NativeFieldInfoPtr_DamagePerTick;
    private static readonly IntPtr NativeFieldInfoPtr_DecreaseTimerInterval;
    private static readonly IntPtr NativeFieldInfoPtr_DecreaseDynamicStacksPerTick;
    private static readonly IntPtr NativeFieldInfoPtr_VisionStartValue;
    private static readonly IntPtr NativeFieldInfoPtr_VisionMinValue;
    private static readonly IntPtr NativeFieldInfoPtr_VisionReductionPerStack;
    private static readonly IntPtr NativeFieldInfoPtr_CurseBlockTimeInterval;
    private static readonly IntPtr NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick;
    private static readonly IntPtr NativeFieldInfoPtr_ImmunityBuff;
    private static readonly IntPtr NativeFieldInfoPtr_BlockCurseBuff;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184563, XrefRangeEnd = 1184571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CursedAreaDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184571, XrefRangeEnd = 1184575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CursedAreaDebuff.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_CursedAreaDebuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_CursedAreaDebuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_CursedAreaDebuff()
    {
      Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CursedAreaDebuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr);
      Script_CursedAreaDebuff.NativeFieldInfoPtr_TimerInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (TimerInterval));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_DynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (DynamicStacksPerTick));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_DamagePerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (DamagePerTick));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseTimerInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (DecreaseTimerInterval));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseDynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (DecreaseDynamicStacksPerTick));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (VisionStartValue));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (VisionMinValue));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (VisionReductionPerStack));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (CurseBlockTimeInterval));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (CurseBlockDecreaseDynamicStacksPerTick));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_ImmunityBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (ImmunityBuff));
      Script_CursedAreaDebuff.NativeFieldInfoPtr_BlockCurseBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (BlockCurseBuff));
      Script_CursedAreaDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, 100664359);
      Script_CursedAreaDebuff.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, 100664360);
      Script_CursedAreaDebuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, 100664361);
    }

    public Script_CursedAreaDebuff(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TimerInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_TimerInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_TimerInterval)) = value;
      }
    }

    public unsafe float DynamicStacksPerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DynamicStacksPerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DynamicStacksPerTick)) = value;
      }
    }

    public unsafe float DamagePerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DamagePerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DamagePerTick)) = value;
      }
    }

    public unsafe float DecreaseTimerInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseTimerInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseTimerInterval)) = value;
      }
    }

    public unsafe float DecreaseDynamicStacksPerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseDynamicStacksPerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_DecreaseDynamicStacksPerTick)) = value;
      }
    }

    public unsafe float VisionStartValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionStartValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionStartValue)) = value;
      }
    }

    public unsafe float VisionMinValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionMinValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionMinValue)) = value;
      }
    }

    public unsafe float VisionReductionPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionReductionPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_VisionReductionPerStack)) = value;
      }
    }

    public unsafe float CurseBlockTimeInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockTimeInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockTimeInterval)) = value;
      }
    }

    public unsafe float CurseBlockDecreaseDynamicStacksPerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_CurseBlockDecreaseDynamicStacksPerTick)) = value;
      }
    }

    public unsafe PrefabGuidComponent ImmunityBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_ImmunityBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_ImmunityBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent BlockCurseBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_BlockCurseBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_CursedAreaDebuff.NativeFieldInfoPtr_BlockCurseBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184503, XrefRangeEnd = 1184521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184521, XrefRangeEnd = 1184545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184545, XrefRangeEnd = 1184563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CursedAreaDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_CursedAreaDebuff>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr);
        Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr, 100664362);
        Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr, 100664363);
        Script_CursedAreaDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr, 100664364);
        Script_CursedAreaDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CursedAreaDebuff.Server>.NativeClassPtr, 100664365);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
