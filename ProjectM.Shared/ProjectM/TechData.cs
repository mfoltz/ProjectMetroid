// Decompiled with JetBrains decompiler
// Type: ProjectM.TechData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TechData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TechCateogry;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_HudSortingOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeverShowQuestionmarkResearch;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public TechCateogry TechCateogry;
    [FieldOffset(16)]
    public float CraftDuration;
    [FieldOffset(20)]
    public int HudSortingOrder;
    [FieldOffset(24)]
    public bool NeverShowQuestionmarkResearch;

    static TechData()
    {
      Il2CppClassPointerStore<TechData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TechData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechData>.NativeClassPtr);
      TechData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (Entity));
      TechData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (Guid));
      TechData.NativeFieldInfoPtr_TechCateogry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (TechCateogry));
      TechData.NativeFieldInfoPtr_CraftDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (CraftDuration));
      TechData.NativeFieldInfoPtr_HudSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (HudSortingOrder));
      TechData.NativeFieldInfoPtr_NeverShowQuestionmarkResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechData>.NativeClassPtr, nameof (NeverShowQuestionmarkResearch));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TechData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
