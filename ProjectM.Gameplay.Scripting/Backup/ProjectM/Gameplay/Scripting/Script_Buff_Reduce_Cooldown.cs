// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_Reduce_Cooldown
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
  public class Script_Buff_Reduce_Cooldown : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Spell_CooldownReduction;
    private static readonly IntPtr NativeFieldInfoPtr_Spell_CooldownReductionPerStack;
    private static readonly IntPtr NativeFieldInfoPtr_Weapon_CooldownReduction;
    private static readonly IntPtr NativeFieldInfoPtr_Weapon_CooldownReductionPerStack;
    private static readonly IntPtr NativeFieldInfoPtr_Travel_CooldownReduction;
    private static readonly IntPtr NativeFieldInfoPtr_Travel_CooldownReductionPerStack;
    private static readonly IntPtr NativeFieldInfoPtr_SpellCooldownModificationId;
    private static readonly IntPtr NativeFieldInfoPtr_WeaponCooldownModificationId;
    private static readonly IntPtr NativeFieldInfoPtr_TravelCooldownModificationId;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183867, XrefRangeEnd = 1183870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_Reduce_Cooldown.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_Reduce_Cooldown()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_Reduce_Cooldown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_Reduce_Cooldown()
    {
      Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_Reduce_Cooldown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr);
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Spell_CooldownReduction));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Spell_CooldownReductionPerStack));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Weapon_CooldownReduction));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Weapon_CooldownReductionPerStack));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Travel_CooldownReduction));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReductionPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Travel_CooldownReductionPerStack));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_SpellCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (SpellCooldownModificationId));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_WeaponCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (WeaponCooldownModificationId));
      Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_TravelCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (TravelCooldownModificationId));
      Script_Buff_Reduce_Cooldown.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, 100664278);
      Script_Buff_Reduce_Cooldown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, 100664279);
    }

    public Script_Buff_Reduce_Cooldown(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Spell_CooldownReduction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReduction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReduction)) = value;
      }
    }

    public unsafe float Spell_CooldownReductionPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReductionPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Spell_CooldownReductionPerStack)) = value;
      }
    }

    public unsafe float Weapon_CooldownReduction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReduction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReduction)) = value;
      }
    }

    public unsafe float Weapon_CooldownReductionPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReductionPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Weapon_CooldownReductionPerStack)) = value;
      }
    }

    public unsafe float Travel_CooldownReduction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReduction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReduction)) = value;
      }
    }

    public unsafe float Travel_CooldownReductionPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReductionPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_Travel_CooldownReductionPerStack)) = value;
      }
    }

    public unsafe ModificationId SpellCooldownModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_SpellCooldownModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_SpellCooldownModificationId)) = value;
      }
    }

    public unsafe ModificationId WeaponCooldownModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_WeaponCooldownModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_WeaponCooldownModificationId)) = value;
      }
    }

    public unsafe ModificationId TravelCooldownModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_TravelCooldownModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_Reduce_Cooldown.NativeFieldInfoPtr_TravelCooldownModificationId)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183789, XrefRangeEnd = 1183817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183817, XrefRangeEnd = 1183842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183842, XrefRangeEnd = 1183867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr);
        Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr, 100664280);
        Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr, 100664281);
        Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr, 100664282);
        Script_Buff_Reduce_Cooldown.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_Reduce_Cooldown.Server>.NativeClassPtr, 100664283);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
