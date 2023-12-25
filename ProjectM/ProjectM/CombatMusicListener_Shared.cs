// Decompiled with JetBrains decompiler
// Type: ProjectM.CombatMusicListener_Shared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CombatMusicListener_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOutro;
    [FieldOffset(0)]
    public PrefabGUID UnitPrefabGuid;
    [FieldOffset(4)]
    public bool PlayOutro;

    static CombatMusicListener_Shared()
    {
      Il2CppClassPointerStore<CombatMusicListener_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CombatMusicListener_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatMusicListener_Shared>.NativeClassPtr);
      CombatMusicListener_Shared.NativeFieldInfoPtr_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_Shared>.NativeClassPtr, nameof (UnitPrefabGuid));
      CombatMusicListener_Shared.NativeFieldInfoPtr_PlayOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatMusicListener_Shared>.NativeClassPtr, nameof (PlayOutro));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombatMusicListener_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
