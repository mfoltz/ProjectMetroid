// Decompiled with JetBrains decompiler
// Type: ProjectM.IOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  public class IOnGameplayEvent : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_EventIds_Public_Abstract_Virtual_New_get_GameplayEventId_EditorArray_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddEventId_Public_Abstract_Virtual_New_Void_GameplayEventIdListener_0;

    public virtual unsafe OnGameplayEventAuthoring.GameplayEventId_EditorArray EventIds
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IOnGameplayEvent.NativeMethodInfoPtr_get_EventIds_Public_Abstract_Virtual_New_get_GameplayEventId_EditorArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (OnGameplayEventAuthoring.GameplayEventId_EditorArray) null : new OnGameplayEventAuthoring.GameplayEventId_EditorArray(pointer);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void AddEventId(GameplayEventIdListener eventId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) eventId));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IOnGameplayEvent.NativeMethodInfoPtr_AddEventId_Public_Abstract_Virtual_New_Void_GameplayEventIdListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOnGameplayEvent()
    {
      Il2CppClassPointerStore<IOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IOnGameplayEvent));
      IOnGameplayEvent.NativeMethodInfoPtr_get_EventIds_Public_Abstract_Virtual_New_get_GameplayEventId_EditorArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOnGameplayEvent>.NativeClassPtr, 100678302);
      IOnGameplayEvent.NativeMethodInfoPtr_AddEventId_Public_Abstract_Virtual_New_Void_GameplayEventIdListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOnGameplayEvent>.NativeClassPtr, 100678303);
    }

    public IOnGameplayEvent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
