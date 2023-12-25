// Decompiled with JetBrains decompiler
// Type: ProjectM.DamageTakenEvent
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
  public struct DamageTakenEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDoT;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCC;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public Entity Source;
    [FieldOffset(16)]
    public bool IsDoT;
    [FieldOffset(17)]
    public bool IgnoreCC;

    static DamageTakenEvent()
    {
      Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DamageTakenEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr);
      DamageTakenEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr, nameof (Entity));
      DamageTakenEvent.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr, nameof (Source));
      DamageTakenEvent.NativeFieldInfoPtr_IsDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr, nameof (IsDoT));
      DamageTakenEvent.NativeFieldInfoPtr_IgnoreCC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr, nameof (IgnoreCC));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageTakenEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
