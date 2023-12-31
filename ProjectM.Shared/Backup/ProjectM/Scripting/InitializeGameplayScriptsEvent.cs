// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.InitializeGameplayScriptsEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InitializeGameplayScriptsEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    [FieldOffset(0)]
    public PrefabGUID TargetPrefabGUID;
    [FieldOffset(4)]
    public Entity TargetEntity;

    static InitializeGameplayScriptsEvent()
    {
      Il2CppClassPointerStore<InitializeGameplayScriptsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (InitializeGameplayScriptsEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeGameplayScriptsEvent>.NativeClassPtr);
      InitializeGameplayScriptsEvent.NativeFieldInfoPtr_TargetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeGameplayScriptsEvent>.NativeClassPtr, nameof (TargetPrefabGUID));
      InitializeGameplayScriptsEvent.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeGameplayScriptsEvent>.NativeClassPtr, nameof (TargetEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeGameplayScriptsEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
