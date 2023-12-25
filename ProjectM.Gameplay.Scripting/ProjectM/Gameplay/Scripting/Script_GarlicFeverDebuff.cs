// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_GarlicFeverDebuff
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
  public class Script_GarlicFeverDebuff : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly IntPtr NativeFieldInfoPtr_WeaponModificationId;
    private static readonly IntPtr NativeFieldInfoPtr_SpellLevel;
    private static readonly IntPtr NativeFieldInfoPtr_SpellModificationId;
    private static readonly IntPtr NativeFieldInfoPtr_ArmorLevel;
    private static readonly IntPtr NativeFieldInfoPtr_ArmorModificationId;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184710, XrefRangeEnd = 1184713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_GarlicFeverDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_GarlicFeverDebuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_GarlicFeverDebuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_GarlicFeverDebuff()
    {
      Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_GarlicFeverDebuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr);
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (WeaponLevel));
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (WeaponModificationId));
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (SpellLevel));
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (SpellModificationId));
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (ArmorLevel));
      Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (ArmorModificationId));
      Script_GarlicFeverDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, 100664377);
      Script_GarlicFeverDebuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, 100664378);
    }

    public Script_GarlicFeverDebuff(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float WeaponLevel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponLevel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponLevel)) = value;
      }
    }

    public unsafe ModificationId WeaponModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_WeaponModificationId)) = value;
      }
    }

    public unsafe float SpellLevel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellLevel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellLevel)) = value;
      }
    }

    public unsafe ModificationId SpellModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_SpellModificationId)) = value;
      }
    }

    public unsafe float ArmorLevel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorLevel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorLevel)) = value;
      }
    }

    public unsafe ModificationId ArmorModificationId
    {
      get
      {
        return *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorModificationId));
      }
      [param: In] set
      {
        *(ModificationId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicFeverDebuff.NativeFieldInfoPtr_ArmorModificationId)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184670, XrefRangeEnd = 1184690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184690, XrefRangeEnd = 1184710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_GarlicFeverDebuff>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr);
        Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr, 100664379);
        Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr, 100664380);
        Script_GarlicFeverDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicFeverDebuff.Server>.NativeClassPtr, 100664381);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
