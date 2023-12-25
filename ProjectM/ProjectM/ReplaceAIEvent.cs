// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAIEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplaceAIEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OldAIEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewAIEntity;
    [FieldOffset(0)]
    public Entity OldAIEntity;
    [FieldOffset(8)]
    public Entity NewAIEntity;

    static ReplaceAIEvent()
    {
      Il2CppClassPointerStore<ReplaceAIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceAIEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAIEvent>.NativeClassPtr);
      ReplaceAIEvent.NativeFieldInfoPtr_OldAIEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAIEvent>.NativeClassPtr, nameof (OldAIEntity));
      ReplaceAIEvent.NativeFieldInfoPtr_NewAIEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAIEvent>.NativeClassPtr, nameof (NewAIEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAIEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
