// Decompiled with JetBrains decompiler
// Type: ProjectM.TickerAuthoring
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
  public class TickerAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TickOnSpawn;
    private static readonly IntPtr NativeFieldInfoPtr_TimeBetweenTicks;
    private static readonly IntPtr NativeFieldInfoPtr_MaxTicks;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040497, XrefRangeEnd = 1040501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TickerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnValidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TickerAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040501, XrefRangeEnd = 1040502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TickerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TickerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TickerAuthoring()
    {
      Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TickerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr);
      TickerAuthoring.NativeFieldInfoPtr_TickOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, nameof (TickOnSpawn));
      TickerAuthoring.NativeFieldInfoPtr_TimeBetweenTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, nameof (TimeBetweenTicks));
      TickerAuthoring.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, nameof (MaxTicks));
      TickerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, 100681488);
      TickerAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, 100681489);
      TickerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TickerAuthoring>.NativeClassPtr, 100681490);
    }

    public TickerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool TickOnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_TickOnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_TickOnSpawn)) = value;
      }
    }

    public unsafe int TimeBetweenTicks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_TimeBetweenTicks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_TimeBetweenTicks)) = value;
      }
    }

    public unsafe int MaxTicks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_MaxTicks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TickerAuthoring.NativeFieldInfoPtr_MaxTicks)) = value;
      }
    }
  }
}
