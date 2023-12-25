// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEventIdSource
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class GameplayEventIdSource : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_GameplayEventId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

    [CallerCount(55)]
    [CachedScanResults(RefRangeStart = 1007421, RefRangeEnd = 1007476, XrefRangeStart = 1007420, XrefRangeEnd = 1007421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventId Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventIdSource.NativeMethodInfoPtr_Convert_Public_GameplayEventId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventId*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool IsValid
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1007477, RefRangeEnd = 1007479, XrefRangeStart = 1007476, XrefRangeEnd = 1007477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventIdSource.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static GameplayEventIdSource()
    {
      Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameplayEventIdSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr);
      GameplayEventIdSource.NativeFieldInfoPtr_GameplayEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, nameof (GameplayEventType));
      GameplayEventIdSource.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, nameof (EventId));
      GameplayEventIdSource.NativeMethodInfoPtr_Convert_Public_GameplayEventId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, 100678187);
      GameplayEventIdSource.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, 100678188);
    }

    public GameplayEventIdSource(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GameplayEventIdSource()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
    }

    public unsafe GameplayEventType GameplayEventType
    {
      get
      {
        return *(GameplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdSource.NativeFieldInfoPtr_GameplayEventType));
      }
      [param: In] set
      {
        *(GameplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdSource.NativeFieldInfoPtr_GameplayEventType)) = value;
      }
    }

    public unsafe string EventId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdSource.NativeFieldInfoPtr_EventId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdSource.NativeFieldInfoPtr_EventId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
