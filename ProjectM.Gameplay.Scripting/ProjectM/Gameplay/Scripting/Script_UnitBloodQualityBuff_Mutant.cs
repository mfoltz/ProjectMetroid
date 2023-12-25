// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_UnitBloodQualityBuff_Mutant
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
  public class Script_UnitBloodQualityBuff_Mutant : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Curve_DamageIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_Curve_HealthIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_Curve_MovementIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_DamageIncreaseMax;
    private static readonly IntPtr NativeFieldInfoPtr_HealthIncreaseMax;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedIncreaseMax;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185212, XrefRangeEnd = 1185215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_UnitBloodQualityBuff_Mutant.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_UnitBloodQualityBuff_Mutant()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_UnitBloodQualityBuff_Mutant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_UnitBloodQualityBuff_Mutant()
    {
      Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_UnitBloodQualityBuff_Mutant));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr);
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_DamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (Curve_DamageIncrease));
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_HealthIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (Curve_HealthIncrease));
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_MovementIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (Curve_MovementIncrease));
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_DamageIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (DamageIncreaseMax));
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_HealthIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (HealthIncreaseMax));
      Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_SpeedIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (SpeedIncreaseMax));
      Script_UnitBloodQualityBuff_Mutant.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, 100664428);
      Script_UnitBloodQualityBuff_Mutant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, 100664429);
    }

    public Script_UnitBloodQualityBuff_Mutant(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CurveReference Curve_DamageIncrease
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_DamageIncrease));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_DamageIncrease)) = value;
      }
    }

    public unsafe CurveReference Curve_HealthIncrease
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_HealthIncrease));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_HealthIncrease)) = value;
      }
    }

    public unsafe CurveReference Curve_MovementIncrease
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_MovementIncrease));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_Curve_MovementIncrease)) = value;
      }
    }

    public unsafe float DamageIncreaseMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_DamageIncreaseMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_DamageIncreaseMax)) = value;
      }
    }

    public unsafe float HealthIncreaseMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_HealthIncreaseMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_HealthIncreaseMax)) = value;
      }
    }

    public unsafe float SpeedIncreaseMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_SpeedIncreaseMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UnitBloodQualityBuff_Mutant.NativeFieldInfoPtr_SpeedIncreaseMax)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185147, XrefRangeEnd = 1185186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185186, XrefRangeEnd = 1185212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr);
        Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr, 100664430);
        Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr, 100664431);
        Script_UnitBloodQualityBuff_Mutant.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Mutant.Server>.NativeClassPtr, 100664432);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
