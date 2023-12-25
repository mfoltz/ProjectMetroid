// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Raven_Projectile_Channel
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Raven_Projectile_Channel : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpellType;
    private static readonly IntPtr NativeFieldInfoPtr_ChannelSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178872, XrefRangeEnd = 1178877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Raven_Projectile_Channel.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Raven_Projectile_Channel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Raven_Projectile_Channel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Raven_Projectile_Channel()
    {
      Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Raven_Projectile_Channel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr);
      Script_Raven_Projectile_Channel.NativeFieldInfoPtr_SpellType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr, nameof (SpellType));
      Script_Raven_Projectile_Channel.NativeFieldInfoPtr_ChannelSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr, nameof (ChannelSequence));
      Script_Raven_Projectile_Channel.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr, 100663754);
      Script_Raven_Projectile_Channel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr, 100663755);
    }

    public Script_Raven_Projectile_Channel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent SpellType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Raven_Projectile_Channel.NativeFieldInfoPtr_SpellType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Raven_Projectile_Channel.NativeFieldInfoPtr_SpellType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ChannelSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Raven_Projectile_Channel.NativeFieldInfoPtr_ChannelSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Raven_Projectile_Channel.NativeFieldInfoPtr_ChannelSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178867, XrefRangeEnd = 1178872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnTick(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Raven_Projectile_Channel.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Raven_Projectile_Channel.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Raven_Projectile_Channel.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Raven_Projectile_Channel.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Raven_Projectile_Channel>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Raven_Projectile_Channel.Server>.NativeClassPtr);
        Script_Raven_Projectile_Channel.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Raven_Projectile_Channel.Server>.NativeClassPtr, 100663756);
        Script_Raven_Projectile_Channel.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Raven_Projectile_Channel.Server>.NativeClassPtr, 100663757);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
