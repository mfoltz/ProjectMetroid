// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_TeleportNearSpellTarget
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_TeleportNearSpellTarget : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_NearAngles;
    private static readonly System.IntPtr NativeFieldInfoPtr_NearSteps;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185007, XrefRangeEnd = 1185010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_TeleportNearSpellTarget.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185010, XrefRangeEnd = 1185011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_TeleportNearSpellTarget()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_TeleportNearSpellTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_TeleportNearSpellTarget()
    {
      Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_TeleportNearSpellTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr);
      Script_TeleportNearSpellTarget.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, nameof (Range));
      Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, nameof (NearAngles));
      Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, nameof (NearSteps));
      Script_TeleportNearSpellTarget.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, 100664412);
      Script_TeleportNearSpellTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, 100664413);
    }

    public Script_TeleportNearSpellTarget(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe float NearAngles
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearAngles));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearAngles)) = value;
      }
    }

    public unsafe int NearSteps
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearSteps));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TeleportNearSpellTarget.NativeFieldInfoPtr_NearSteps)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Sorter
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetPosition;
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_float3_float3_0;
      [FieldOffset(0)]
      public float3 TargetPosition;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184965, XrefRangeEnd = 1184966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(float3 x, float3 y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_TeleportNearSpellTarget.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Sorter()
      {
        Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Sorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, nameof (Sorter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Sorter>.NativeClassPtr);
        Script_TeleportNearSpellTarget.Sorter.NativeFieldInfoPtr_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Sorter>.NativeClassPtr, nameof (TargetPosition));
        Script_TeleportNearSpellTarget.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Sorter>.NativeClassPtr, 100664414);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Sorter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Private_Static_float3_ServerGameManager_float3_quaternion_Single_Single_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184966, XrefRangeEnd = 1184997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1185006, RefRangeEnd = 1185007, XrefRangeStart = 1184997, XrefRangeEnd = 1185006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float3 GetPosition(
        ServerGameManager game,
        float3 startPosition,
        quaternion rotation,
        float range,
        float angleDiff,
        float collisionRadius)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &range;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &angleDiff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionRadius;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr_GetPosition_Private_Static_float3_ServerGameManager_float3_quaternion_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_TeleportNearSpellTarget>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr);
        Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr, 100664415);
        Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr_GetPosition_Private_Static_float3_ServerGameManager_float3_quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr, 100664416);
        Script_TeleportNearSpellTarget.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TeleportNearSpellTarget.Server>.NativeClassPtr, 100664417);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
