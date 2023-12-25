// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnTickAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CreateGameplayEventOnTickAuthoring : CreateGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Target;
    private static readonly IntPtr NativeFieldInfoPtr_TickInterval;
    private static readonly IntPtr NativeFieldInfoPtr_TickOnSpawn;
    private static readonly IntPtr NativeFieldInfoPtr_CallScriptOnTick;
    private static readonly IntPtr NativeFieldInfoPtr_MaxTicks;
    private static readonly IntPtr NativeFieldInfoPtr_RandomTickOffset;
    private static readonly IntPtr NativeFieldInfoPtr_RandomTickInterval;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007666, XrefRangeEnd = 1007684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnTickAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventOnTickAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnTickAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventOnTickAuthoring()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnTickAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr);
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (Target));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (TickInterval));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (TickOnSpawn));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_CallScriptOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (CallScriptOnTick));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (MaxTicks));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (RandomTickOffset));
      CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, nameof (RandomTickInterval));
      CreateGameplayEventOnTickAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, 100678217);
      CreateGameplayEventOnTickAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnTickAuthoring>.NativeClassPtr, 100678218);
    }

    public CreateGameplayEventOnTickAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayEventTarget Target
    {
      get
      {
        return *(GameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_Target));
      }
      [param: In] set
      {
        *(GameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_Target)) = value;
      }
    }

    public unsafe float TickInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickInterval)) = value;
      }
    }

    public unsafe bool TickOnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickOnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_TickOnSpawn)) = value;
      }
    }

    public unsafe bool CallScriptOnTick
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_CallScriptOnTick));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_CallScriptOnTick)) = value;
      }
    }

    public unsafe int MaxTicks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_MaxTicks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_MaxTicks)) = value;
      }
    }

    public unsafe float RandomTickOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickOffset)) = value;
      }
    }

    public unsafe float RandomTickInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnTickAuthoring.NativeFieldInfoPtr_RandomTickInterval)) = value;
      }
    }
  }
}
