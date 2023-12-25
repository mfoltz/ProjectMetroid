// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTileHeightsDebugNew
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShowTileHeightsDebugNew
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelativeToPlayerHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0;
    [FieldOffset(0)]
    public ShowTileHeightsDebugNew.HeightType Type;
    [FieldOffset(4)]
    public float Radius;
    [FieldOffset(8)]
    public bool RelativeToPlayerHeight;

    public virtual unsafe float ProjectM\u002EIShowTileGridComponentData\u002ERadius
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsDebugNew.NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ShowTileHeightsDebugNew()
    {
      Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTileHeightsDebugNew));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr);
      ShowTileHeightsDebugNew.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr, nameof (Type));
      ShowTileHeightsDebugNew.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr, nameof (Radius));
      ShowTileHeightsDebugNew.NativeFieldInfoPtr_RelativeToPlayerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr, nameof (RelativeToPlayerHeight));
      ShowTileHeightsDebugNew.NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr, 100684698);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsDebugNew>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum HeightType
    {
      Gameplay,
      CellBaseHeightLevel,
    }
  }
}
