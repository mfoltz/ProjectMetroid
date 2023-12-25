// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEventIdListener
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
  public sealed class GameplayEventIdListener : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_GameplayEventId_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1008127, RefRangeEnd = 1008128, XrefRangeStart = 1008127, XrefRangeEnd = 1008127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventId Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventIdListener.NativeMethodInfoPtr_Convert_Public_GameplayEventId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameplayEventIdListener()
    {
      Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameplayEventIdListener));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr);
      GameplayEventIdListener.NativeFieldInfoPtr_GameplayEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr, nameof (GameplayEventType));
      GameplayEventIdListener.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr, nameof (EventId));
      GameplayEventIdListener.NativeMethodInfoPtr_Convert_Public_GameplayEventId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr, 100678301);
    }

    public GameplayEventIdListener(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GameplayEventIdListener()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdListener>.NativeClassPtr, data));
    }

    public unsafe GameplayEventType GameplayEventType
    {
      get
      {
        return *(GameplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdListener.NativeFieldInfoPtr_GameplayEventType));
      }
      [param: In] set
      {
        *(GameplayEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdListener.NativeFieldInfoPtr_GameplayEventType)) = value;
      }
    }

    public unsafe string EventId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdListener.NativeFieldInfoPtr_EventId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventIdListener.NativeFieldInfoPtr_EventId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
