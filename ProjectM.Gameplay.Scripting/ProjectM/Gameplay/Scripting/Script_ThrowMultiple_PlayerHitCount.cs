// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ThrowMultiple_PlayerHitCount
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
  public class Script_ThrowMultiple_PlayerHitCount : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ThrowComponent;
    private static readonly IntPtr NativeFieldInfoPtr_CountPerVampire_Min;
    private static readonly IntPtr NativeFieldInfoPtr_CountPerVampire_Max;
    private static readonly IntPtr NativeFieldInfoPtr_MaxVampireCount;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_CountCurve;
    private static readonly IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178594, XrefRangeEnd = 1178603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ThrowMultiple_PlayerHitCount.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178603, XrefRangeEnd = 1178604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ThrowMultiple_PlayerHitCount()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ThrowMultiple_PlayerHitCount()
    {
      Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ThrowMultiple_PlayerHitCount));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr);
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_ThrowComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (ThrowComponent));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (CountPerVampire_Min));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (CountPerVampire_Max));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxVampireCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (MaxVampireCount));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (MaxRange));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (RandomAngle));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (OffsetAngle));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (AlwaysMaxRange));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (IndividualRandom));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (TargetHitFilter));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (CountCurve));
      Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_ThrowMultiple_PlayerHitCount.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, 100663723);
      Script_ThrowMultiple_PlayerHitCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, 100663724);
    }

    public Script_ThrowMultiple_PlayerHitCount(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ThrowComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_ThrowComponent));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_ThrowComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int CountPerVampire_Min
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Min));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Min)) = value;
      }
    }

    public unsafe int CountPerVampire_Max
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Max));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountPerVampire_Max)) = value;
      }
    }

    public unsafe int MaxVampireCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxVampireCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxVampireCount)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public unsafe float RandomAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_RandomAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_RandomAngle)) = value;
      }
    }

    public unsafe float OffsetAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_OffsetAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_OffsetAngle)) = value;
      }
    }

    public unsafe bool AlwaysMaxRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_AlwaysMaxRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_AlwaysMaxRange)) = value;
      }
    }

    public unsafe bool IndividualRandom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_IndividualRandom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_IndividualRandom)) = value;
      }
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public unsafe CurveReference CountCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_CountCurve)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ThrowMultiple_PlayerHitCount.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_MultiThrowHitCounter_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_byref_Int32_0;
      private static readonly IntPtr NativeMethodInfoPtr_SpawnThrowPerCount_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_ThrowMultiple_PlayerHitCount_DataServer_Int32_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178496, XrefRangeEnd = 1178540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1178557, RefRangeEnd = 1178558, XrefRangeStart = 1178540, XrefRangeEnd = 1178557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool MultiThrowHitCounter(
        ref ServerGameManager game,
        SelfServer self,
        Entity targetHit,
        ref int hits)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &targetHit;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref hits;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_MultiThrowHitCounter_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_byref_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1178593, RefRangeEnd = 1178594, XrefRangeStart = 1178558, XrefRangeEnd = 1178593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnThrowPerCount(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ThrowMultiple_PlayerHitCount_DataServer dataServer,
        int count)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dataServer;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &count;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_SpawnThrowPerCount_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_ThrowMultiple_PlayerHitCount_DataServer_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr);
        Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr, 100663725);
        Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_MultiThrowHitCounter_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr, 100663726);
        Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr_SpawnThrowPerCount_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_ThrowMultiple_PlayerHitCount_DataServer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr, 100663727);
        Script_ThrowMultiple_PlayerHitCount.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Server>.NativeClassPtr, 100663728);
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
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ThrowMultiple_PlayerHitCount.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Client>.NativeClassPtr);
        Script_ThrowMultiple_PlayerHitCount.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ThrowMultiple_PlayerHitCount.Client>.NativeClassPtr, 100663729);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
