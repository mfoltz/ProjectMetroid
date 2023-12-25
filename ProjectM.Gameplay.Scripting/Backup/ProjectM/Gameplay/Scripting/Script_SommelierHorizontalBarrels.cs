// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SommelierHorizontalBarrels
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
  public class Script_SommelierHorizontalBarrels : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnEntity;
    private static readonly IntPtr NativeFieldInfoPtr_Amount;
    private static readonly IntPtr NativeFieldInfoPtr_Waves;
    private static readonly IntPtr NativeFieldInfoPtr_Spacing;
    private static readonly IntPtr NativeFieldInfoPtr_DelayBetweenWaves;
    private static readonly IntPtr NativeFieldInfoPtr_DelayBetween_Min;
    private static readonly IntPtr NativeFieldInfoPtr_DelayBetween_Max;
    private static readonly IntPtr NativeFieldInfoPtr_RoomSizeOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189097, XrefRangeEnd = 1189106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SommelierHorizontalBarrels.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SommelierHorizontalBarrels()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SommelierHorizontalBarrels.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SommelierHorizontalBarrels()
    {
      Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SommelierHorizontalBarrels));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr);
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_SpawnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (SpawnEntity));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (Amount));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Waves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (Waves));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (Spacing));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetweenWaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (DelayBetweenWaves));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (DelayBetween_Min));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (DelayBetween_Max));
      Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_RoomSizeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (RoomSizeOffset));
      Script_SommelierHorizontalBarrels.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, 100664802);
      Script_SommelierHorizontalBarrels.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, 100664803);
    }

    public Script_SommelierHorizontalBarrels(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent SpawnEntity
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_SpawnEntity));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_SpawnEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Amount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Amount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Amount)) = value;
      }
    }

    public unsafe int Waves
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Waves));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Waves)) = value;
      }
    }

    public unsafe float Spacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Spacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_Spacing)) = value;
      }
    }

    public unsafe float DelayBetweenWaves
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetweenWaves));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetweenWaves)) = value;
      }
    }

    public unsafe float DelayBetween_Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Min)) = value;
      }
    }

    public unsafe float DelayBetween_Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_DelayBetween_Max)) = value;
      }
    }

    public unsafe float RoomSizeOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_RoomSizeOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SommelierHorizontalBarrels.NativeFieldInfoPtr_RoomSizeOffset)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189000, XrefRangeEnd = 1189037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189037, XrefRangeEnd = 1189097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr);
        Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr, 100664804);
        Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr, 100664805);
        Script_SommelierHorizontalBarrels.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SommelierHorizontalBarrels.Server>.NativeClassPtr, 100664806);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
