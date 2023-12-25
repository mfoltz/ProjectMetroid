// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.CurrentVoiceLine
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CurrentVoiceLine
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceLineEntity;
    [FieldOffset(0)]
    public Entity VoiceLineEntity;

    static CurrentVoiceLine()
    {
      Il2CppClassPointerStore<CurrentVoiceLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (CurrentVoiceLine));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentVoiceLine>.NativeClassPtr);
      CurrentVoiceLine.NativeFieldInfoPtr_VoiceLineEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentVoiceLine>.NativeClassPtr, nameof (VoiceLineEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurrentVoiceLine>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
