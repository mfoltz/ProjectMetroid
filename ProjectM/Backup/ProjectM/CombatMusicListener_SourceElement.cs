// Decompiled with JetBrains decompiler
// Type: ProjectM.CombatMusicListener_SourceElement
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
  public struct CombatMusicListener_SourceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasKilledByAlly;
    [FieldOffset(0)]
    public Entity UnitEntity;
    [FieldOffset(8)]
    public bool WasKilledByAlly;

    static CombatMusicListener_SourceElement()
    {
      Il2CppClassPointerStore<CombatMusicListener_SourceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CombatMusicListener_SourceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatMusicListener_SourceElement>.NativeClassPtr);
      CombatMusicListener_SourceElement.NativeFieldInfoPtr_UnitEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_SourceElement>.NativeClassPtr, nameof (UnitEntity));
      CombatMusicListener_SourceElement.NativeFieldInfoPtr_WasKilledByAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_SourceElement>.NativeClassPtr, nameof (WasKilledByAlly));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombatMusicListener_SourceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
